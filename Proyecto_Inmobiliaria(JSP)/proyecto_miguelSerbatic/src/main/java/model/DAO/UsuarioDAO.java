package model.DAO;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.List;

import org.jasypt.util.password.StrongPasswordEncryptor;

import conexion.Conexion;
import model.VO.UsuarioVO;

public class UsuarioDAO {

	public static UsuarioVO getUsuario(String email) {

		UsuarioVO usuario = new UsuarioVO();
		PreparedStatement statement = null;
		Connection connection = Conexion.getConexion();
		String sql = "SELECT * FROM usuarios WHERE email = ?";
		try {
			statement = connection.prepareStatement(sql);
			statement.setString(1, email);
			ResultSet rs = statement.executeQuery();

			if (rs.next()) {
				usuario.setId(rs.getInt("id"));
				usuario.setRolId(rs.getInt("id_rol"));
				usuario.setEmail(rs.getString("email"));
				usuario.setClave(rs.getString("clave"));
				usuario.setNombre(rs.getString("nombre"));
				usuario.setApellido1(rs.getString("apellido1"));
				usuario.setApellido2(rs.getString("apellido2"));
				usuario.setDireccion(rs.getString("direccion"));
				usuario.setProvincia(rs.getString("provincia"));
				usuario.setLocalidad(rs.getString("localidad"));
				usuario.setTelefono(rs.getString("telefono"));
				usuario.setDni(rs.getString("dni"));
				usuario.setBaja(rs.getBoolean("baja"));
				return usuario;
			} else {
				return null;
			}
		} catch (SQLException e) {
			e.printStackTrace();
		}
		return null;
	}
	
	public static UsuarioVO getUsuarioActivo(String email) {

		UsuarioVO usuario = new UsuarioVO();
		PreparedStatement statement = null;
		Connection connection = Conexion.getConexion();
		String sql = "SELECT * FROM usuarios WHERE email = ? AND baja = false";
		try {
			statement = connection.prepareStatement(sql);
			statement.setString(1, email);
			ResultSet rs = statement.executeQuery();

			if (rs.next()) {
				usuario.setId(rs.getInt("id"));
				usuario.setRolId(rs.getInt("id_rol"));
				usuario.setEmail(rs.getString("email"));
				usuario.setClave(rs.getString("clave"));
				usuario.setNombre(rs.getString("nombre"));
				usuario.setApellido1(rs.getString("apellido1"));
				usuario.setApellido2(rs.getString("apellido2"));
				usuario.setDireccion(rs.getString("direccion"));
				usuario.setProvincia(rs.getString("provincia"));
				usuario.setLocalidad(rs.getString("localidad"));
				usuario.setTelefono(rs.getString("telefono"));
				usuario.setDni(rs.getString("dni"));
				usuario.setBaja(rs.getBoolean("baja"));
				return usuario;
			} else {
				return null;
			}
		} catch (SQLException e) {
			e.printStackTrace();
		}
		return null;
	}

	public static UsuarioVO obtenerPorId(int id) {
		UsuarioVO usuario = null;
		PreparedStatement statement = null;
		Connection connection = Conexion.getConexion();
		String sql = "SELECT * FROM usuarios WHERE id = ?";
		try {
			statement = connection.prepareStatement(sql);
			statement.setInt(1, id);
			ResultSet rs = statement.executeQuery();

			if (rs.next()) {
				usuario = new UsuarioVO();
				usuario.setId(rs.getInt("id"));
				usuario.setRolId(rs.getInt("id_rol"));
				usuario.setEmail(rs.getString("email"));
				usuario.setClave(rs.getString("clave"));
				usuario.setNombre(rs.getString("nombre"));
				usuario.setApellido1(rs.getString("apellido1"));
				usuario.setApellido2(rs.getString("apellido2"));
				usuario.setDireccion(rs.getString("direccion"));
				usuario.setProvincia(rs.getString("provincia"));
				usuario.setLocalidad(rs.getString("localidad"));
				usuario.setTelefono(rs.getString("telefono"));
				usuario.setDni(rs.getString("dni"));
				usuario.setBaja(rs.getBoolean("baja"));
			}
		} catch (SQLException e) {
			e.printStackTrace();
		}
		return usuario;
	}

	public static boolean actualizarBaja(int id, boolean baja) {
		Connection con = null;
		PreparedStatement st = null;
		try {
			con = Conexion.getConexion();
			String sql = "UPDATE usuarios SET baja = ? WHERE id = ?";
			st = con.prepareStatement(sql);
			st.setBoolean(1, baja);
			st.setInt(2, id);
			int filasAfectadas = st.executeUpdate();
			if (filasAfectadas > 0) {
				con.commit();
				return true;
			} else {
				return false;
			}
		} catch (SQLException e) {
			e.printStackTrace();
			return false;
		}
	}

	public static List<UsuarioVO> getUsuarios(String sentencia) {
		List<UsuarioVO> usuarios = new ArrayList<>();
		PreparedStatement statement = null;
		Connection connection = Conexion.getConexion();
		String sql = "SELECT * FROM usuarios WHERE " + sentencia;
		try {
			statement = connection.prepareStatement(sql);
			ResultSet rs = statement.executeQuery();

			while (rs.next()) {
				UsuarioVO usuario = new UsuarioVO();
				usuario.setId(rs.getInt("id"));
				usuario.setRolId(rs.getInt("id_rol"));
				usuario.setEmail(rs.getString("email"));
				usuario.setClave(rs.getString("clave"));
				usuario.setNombre(rs.getString("nombre"));
				usuario.setApellido1(rs.getString("apellido1"));
				usuario.setApellido2(rs.getString("apellido2"));
				usuario.setDireccion(rs.getString("direccion"));
				usuario.setProvincia(rs.getString("provincia"));
				usuario.setLocalidad(rs.getString("localidad"));
				usuario.setTelefono(rs.getString("telefono"));
				usuario.setDni(rs.getString("dni"));
				usuario.setBaja(rs.getBoolean("baja"));
				usuarios.add(usuario);
			}
		} catch (SQLException e) {
			e.printStackTrace();
		}
		return usuarios;
	}

	public static UsuarioVO getUsuario(int id) {

		UsuarioVO usuario = new UsuarioVO();
		PreparedStatement statement = null;
		Connection connection = Conexion.getConexion();
		String sql = "SELECT * FROM usuarios WHERE id = ?";
		try {
			statement = connection.prepareStatement(sql);
			statement.setInt(1, id);
			ResultSet rs = statement.executeQuery();

			if (rs.next()) {
				usuario.setId(rs.getInt("id"));
				usuario.setRolId(rs.getInt("id_rol"));
				usuario.setEmail(rs.getString("email"));
				usuario.setClave(rs.getString("clave"));
				usuario.setNombre(rs.getString("nombre"));
				usuario.setApellido1(rs.getString("apellido1"));
				usuario.setApellido2(rs.getString("apellido2"));
				usuario.setDireccion(rs.getString("direccion"));
				usuario.setProvincia(rs.getString("provincia"));
				usuario.setLocalidad(rs.getString("localidad"));
				usuario.setTelefono(rs.getString("telefono"));
				usuario.setDni(rs.getString("dni"));
				usuario.setBaja(rs.getBoolean("baja"));
				return usuario;
			} else {
				return null;
			}
		} catch (SQLException e) {
			e.printStackTrace();
		}
		return null;
	}

	public static boolean insertarUsuario(String email, String clave, String nombre, String apellido1, String apellido2,
			String direccion, String provincia, String localidad, String telefono, String dni) {
		Connection connection = Conexion.getConexion();
		PreparedStatement statement = null;
		boolean insercionExitosa = false;
		String sql = "INSERT INTO usuarios (id_rol, email, clave, nombre, apellido1, apellido2, direccion, provincia, localidad, telefono, dni) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";

		try {
			StrongPasswordEncryptor passwordEncryptor = new StrongPasswordEncryptor();
			String encryptedPassword = passwordEncryptor.encryptPassword(clave);

			statement = connection.prepareStatement(sql);
			statement.setInt(1, 1);
			statement.setString(2, email);
			statement.setString(3, encryptedPassword);
			statement.setString(4, nombre);
			statement.setString(5, apellido1);
			statement.setString(6, apellido2);
			statement.setString(7, direccion);
			statement.setString(8, provincia);
			statement.setString(9, localidad);
			statement.setString(10, telefono);
			statement.setString(11, dni);

			int filasInsertadas = statement.executeUpdate();
			if (filasInsertadas > 0) {
				insercionExitosa = true;
				connection.commit();
			} else {
				insercionExitosa = false;
			}
		} catch (SQLException e) {
			e.printStackTrace();
		}
		return insercionExitosa;
	}

	public static UsuarioVO insertarUsuario(UsuarioVO usuario, int idRol) {
		Connection connection = Conexion.getConexion();
		PreparedStatement statement = null;
		UsuarioVO usuarioInsertado = null;
		String sql = "INSERT INTO usuarios (id_rol, email, clave, nombre, apellido1, apellido2, direccion, provincia, localidad, telefono, dni) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";

		try {
			StrongPasswordEncryptor passwordEncryptor = new StrongPasswordEncryptor();
			String encryptedPassword = passwordEncryptor.encryptPassword(usuario.getClave());

			statement = connection.prepareStatement(sql);
			statement.setInt(1, idRol);
			statement.setString(2, usuario.getEmail());
			statement.setString(3, encryptedPassword);
			statement.setString(4, usuario.getNombre());
			statement.setString(5, usuario.getApellido1());
			statement.setString(6, usuario.getApellido2());
			statement.setString(7, usuario.getDireccion());
			statement.setString(8, usuario.getProvincia());
			statement.setString(9, usuario.getLocalidad());
			statement.setString(10, usuario.getTelefono());
			statement.setString(11, usuario.getDni());

			int filasInsertadas = statement.executeUpdate();
			if (filasInsertadas > 0) {
				connection.commit();
			}
		} catch (SQLException e) {
			e.printStackTrace();
		}
		return usuarioInsertado;
	}

	public static boolean actualizarUsuario(int id, String email, String clave, String nombre, String apellido1,
			String apellido2, String direccion, String provincia, String localidad, String telefono, String dni) {
		Connection connection = Conexion.getConexion();
		PreparedStatement statement = null;
		boolean actualizacionExitosa = false;
		String sql = "UPDATE usuarios SET email=?, clave=?, nombre=?, apellido1=?, apellido2=?, direccion=?, provincia=?, localidad=?, telefono=?, dni=? WHERE id=?";
		UsuarioVO usuario = getUsuario(id);
		try {
			StrongPasswordEncryptor passwordEncryptor = new StrongPasswordEncryptor();
			String encryptedPassword = passwordEncryptor.encryptPassword(clave);

			statement = connection.prepareStatement(sql);
			statement.setString(1, email);
			if (clave == "" || clave == null) {
				statement.setString(2, usuario.getClave());
			} else {
				statement.setString(2, encryptedPassword);
			}
			statement.setString(3, nombre);
			statement.setString(4, apellido1);
			statement.setString(5, apellido2);
			statement.setString(6, direccion);
			statement.setString(7, provincia);
			statement.setString(8, localidad);
			statement.setString(9, telefono);
			statement.setString(10, dni);
			statement.setInt(11, id);

			int filasActualizadas = statement.executeUpdate();
			if (filasActualizadas > 0) {
				actualizacionExitosa = true;
				connection.commit();
			} else {
				actualizacionExitosa = false;
			}
		} catch (SQLException e) {
			e.printStackTrace();
		}
		return actualizacionExitosa;
	}
	
	public static boolean actualizarSuperAdmin(String email, String clave) {
	    Connection connection = Conexion.getConexion();
	    PreparedStatement statement = null;
	    boolean actualizacionExitosa = false;
	    String sql = "UPDATE usuarios SET email=?, clave=? WHERE id_rol = 4";

	    try {
	        StrongPasswordEncryptor passwordEncryptor = new StrongPasswordEncryptor();
	        String encryptedPassword = passwordEncryptor.encryptPassword(clave);

	        statement = connection.prepareStatement(sql);
	        statement.setString(1, email);
	        statement.setString(2, encryptedPassword);

	        int filasActualizadas = statement.executeUpdate();
	        if (filasActualizadas > 0) {
	            actualizacionExitosa = true;
	            connection.commit();
	        } else {
	            actualizacionExitosa = false;
	        }
	    } catch (SQLException e) {
	        e.printStackTrace();
	    }
	    return actualizacionExitosa;
	}


	public static boolean actualizarUsuario(UsuarioVO usuario) {
		Connection connection = Conexion.getConexion();
		PreparedStatement statement = null;
		boolean actualizacionExitosa = false;
		String sql = "UPDATE usuarios SET id_rol=?, email=?, clave=?, nombre=?, apellido1=?, apellido2=?, direccion=?, provincia=?, localidad=?, telefono=?, dni=? WHERE id=?";
		try {
			StrongPasswordEncryptor passwordEncryptor = new StrongPasswordEncryptor();
			String encryptedPassword = passwordEncryptor.encryptPassword(usuario.getClave());

			statement = connection.prepareStatement(sql);
			statement.setInt(1, usuario.getRolId());
			statement.setString(2, usuario.getEmail());
			if (usuario.getClave() == null || usuario.getClave().isEmpty()) {
				statement.setString(3, usuario.getClave());
			} else {
				statement.setString(3, encryptedPassword);
			}
			statement.setString(4, usuario.getNombre());
			statement.setString(5, usuario.getApellido1());
			statement.setString(6, usuario.getApellido2());
			statement.setString(7, usuario.getDireccion());
			statement.setString(8, usuario.getProvincia());
			statement.setString(9, usuario.getLocalidad());
			statement.setString(10, usuario.getTelefono());
			statement.setString(11, usuario.getDni());
			statement.setInt(12, usuario.getId());

			int filasActualizadas = statement.executeUpdate();
			if (filasActualizadas > 0) {
				actualizacionExitosa = true;
				connection.commit();
			} else {
				actualizacionExitosa = false;
			}
		} catch (SQLException e) {
			e.printStackTrace();
		}
		return actualizacionExitosa;
	}

	public static boolean insertarSuperAdmin() {
		Connection connection = Conexion.getConexion();
		PreparedStatement statement = null;
		String sql = "INSERT INTO usuarios (id_rol, nombre, email, clave) SELECT 4, ?, ?, ? FROM DUAL WHERE NOT EXISTS (SELECT * FROM usuarios WHERE id_rol = 4)";

		try {
			StrongPasswordEncryptor passwordEncryptor = new StrongPasswordEncryptor();
			String encryptedPassword = passwordEncryptor.encryptPassword("admin");

			statement = connection.prepareStatement(sql);
			statement.setString(1, "admin");
			statement.setString(2, "admin@admin.es");
			statement.setString(3, encryptedPassword);

			statement.executeUpdate();
			connection.commit();
			return true;

		} catch (SQLException e) {
			e.printStackTrace();
		}
		return false;
	}

	public static String claveSuperAdmin() {
		Connection connection = Conexion.getConexion();
		PreparedStatement statement = null;
		String clave;
		String sql = "SELECT clave FROM usuarios WHERE id_rol = 4";
		try {
			statement = connection.prepareStatement(sql);
			ResultSet rs = statement.executeQuery();

			if (rs.next()) {
				clave = rs.getString("clave");
				return clave;
			}
		} catch (SQLException e) {
			e.printStackTrace();
		}
		return "";
	}

}
