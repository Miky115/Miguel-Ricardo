package service;

import java.util.List;

import org.jasypt.util.password.StrongPasswordEncryptor;

import model.DAO.UsuarioDAO;
import model.VO.UsuarioVO;

public class UsuarioServicio {
	public static UsuarioVO comprobarUsuario(String email, String password) {
		UsuarioVO usuario = UsuarioDAO.getUsuarioActivo(email);
		StrongPasswordEncryptor passwordEncryptor = new StrongPasswordEncryptor();
		if (usuario == null) {
			return null;
		} else {
			if (passwordEncryptor.checkPassword(password, usuario.getClave())) {
				return usuario;
			} else {
				return null;
			}
		}
	}

	public static boolean verificarContrasena(String email, String clave, String claveRepetir, String nombre,
			String apellido1, String apellido2, String direccion, String provincia, String localidad, String telefono,
			String dni) {

		boolean insertado = UsuarioDAO.insertarUsuario(email, clave, nombre, apellido1, apellido2, direccion, provincia,
				localidad, telefono, dni);
		return insertado && clave.equals(claveRepetir);
	}

	public static boolean verificarCambioContrasena(int id, String email, String clave, String claveRepetir,
			String nombre, String apellido1, String apellido2, String direccion, String provincia, String localidad,
			String telefono, String dni) {

		boolean actualizado = UsuarioDAO.actualizarUsuario(id, email, clave, nombre, apellido1, apellido2, direccion,
				provincia, localidad, telefono, dni);
		return actualizado && clave.equals(claveRepetir);
	}

	public static void bajaUsuario(int id) {
		UsuarioDAO.actualizarBaja(id, true);
	}

	public static void activarUsuario(int id) {
		UsuarioDAO.actualizarBaja(id, false);
	}

	public static List<UsuarioVO> verClientes() {
		List<UsuarioVO> clientes = UsuarioDAO.getUsuarios("id_rol = 1");
		return clientes;
	}

	public static List<UsuarioVO> verEmpleados() {
		List<UsuarioVO> empleados = UsuarioDAO.getUsuarios("id_rol = 2");
		return empleados;
	}
	
	public static List<UsuarioVO> verAdministradores() {
		List<UsuarioVO> empleados = UsuarioDAO.getUsuarios("id_rol = 3");
		return empleados;
	}
	
	public static void crearClientes(UsuarioVO usuario) {
		UsuarioDAO.insertarUsuario(usuario, 1);
	}

	public static void crearEmpleados(UsuarioVO usuario) {
		UsuarioDAO.insertarUsuario(usuario, 2);
	}
	
	public static void crearAdministradores(UsuarioVO usuario) {
		UsuarioDAO.insertarUsuario(usuario, 3);
	}
}
