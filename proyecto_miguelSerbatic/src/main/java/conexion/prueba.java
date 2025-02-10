package conexion;

import org.hibernate.*;

import hibernate.VO.*;

public class prueba {
	public static void main(String[] args) {
		// Obtener la SessionFactory
		SessionFactory sessionFactory = HibernateUtil.getSessionFactory();

		// Abrir una sesión (conexión a la base de datos)
		Session session = sessionFactory.openSession();

		// Iniciar una transacción
		Transaction transaction = session.beginTransaction();

		try {
			// Crear un nuevo usuario
			Roles roles = new Roles();
			roles.setRol("cliente");
			Usuarios usuario = new Usuarios(2, roles, "example@example.com", "password", "John", "Doe", null, null,
					null, null, null, "12345678", null, null);

			// Guardar el usuario en la base de datos
			session.save(usuario);

			// Commit de la transacción
			transaction.commit();

			// Imprimir mensaje de éxito
			System.out.println("Usuario guardado correctamente con ID: " + usuario.getId());

			// Recuperar el usuario guardado desde la base de datos
			Usuarios usuarioRecuperado = session.get(Usuarios.class, usuario.getId());
			if (usuarioRecuperado != null) {
				System.out.println("Usuario recuperado de la base de datos:");
				System.out.println(usuarioRecuperado);
			} else {
				System.out.println("No se pudo recuperar el usuario de la base de datos.");
			}
		} catch (Exception e) {
			// En caso de error, hacer rollback de la transacción
			if (transaction != null) {
				transaction.rollback();
			}
			e.printStackTrace();
		} finally {
			// Cerrar la sesión
			session.close();
			// Cerrar la SessionFactory (liberar recursos)
			sessionFactory.close();
		}
	}
}
