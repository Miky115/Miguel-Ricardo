package model.DAO;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.List;

import conexion.Conexion;
import model.VO.ProveedorVO;

public class ProveedorDAO {
	public static boolean insertProveedor(ProveedorVO proveedor) {
		Connection connection = null;
		PreparedStatement statement = null;
		boolean inserted = false;
		try {
			connection = Conexion.getConexion();
			String sql = "INSERT INTO proveedores (nombre, direccion, localidad, provincia, telefono, cif, email) VALUES (?, ?, ?, ?, ?, ?, ?)";
			statement = connection.prepareStatement(sql);
			statement.setString(1, proveedor.getNombre());
			statement.setString(2, proveedor.getDireccion());
			statement.setString(3, proveedor.getLocalidad());
			statement.setString(4, proveedor.getProvincia());
			statement.setString(5, proveedor.getTelefono());
			statement.setString(6, proveedor.getCif());
			statement.setString(7, proveedor.getEmail());
			int rowsInserted = statement.executeUpdate();
			if (rowsInserted > 0) {
				inserted = true;
				connection.commit();
			}
		} catch (SQLException e) {
			e.printStackTrace();
		}
		return inserted;
	}

	public static boolean deleteProveedor(int id) {
		Connection connection = null;
		PreparedStatement statement = null;
		boolean deleted = false;
		try {
			connection = Conexion.getConexion();
			String sql = "DELETE FROM proveedores WHERE id = ?";
			statement = connection.prepareStatement(sql);
			statement.setInt(1, id);
			int rowsDeleted = statement.executeUpdate();
			if (rowsDeleted > 0) {
				deleted = true;
				connection.commit();
			}
		} catch (SQLException e) {
			e.printStackTrace();
		}
		return deleted;
	}

	public static boolean updateProveedor(ProveedorVO proveedor) {
		Connection connection = null;
		PreparedStatement statement = null;
		boolean updated = false;
		try {
			connection = Conexion.getConexion();
			String sql = "UPDATE proveedores SET nombre = ?, direccion = ?, localidad = ?, provincia = ?, telefono = ?, cif = ?, email = ? WHERE id = ?";
			statement = connection.prepareStatement(sql);
			statement.setString(1, proveedor.getNombre());
			statement.setString(2, proveedor.getDireccion());
			statement.setString(3, proveedor.getLocalidad());
			statement.setString(4, proveedor.getProvincia());
			statement.setString(5, proveedor.getTelefono());
			statement.setString(6, proveedor.getCif());
			statement.setString(7, proveedor.getEmail());
			statement.setInt(8, proveedor.getId());
			int rowsUpdated = statement.executeUpdate();
			if (rowsUpdated > 0) {
				updated = true;
				connection.commit();
			}
		} catch (SQLException e) {
			e.printStackTrace();
		}
		return updated;
	}

	public static List<ProveedorVO> getProveedores() {
		Connection connection = null;
		PreparedStatement statement = null;
		ResultSet resultSet = null;
		List<ProveedorVO> proveedores = new ArrayList<>();
		try {
			connection = Conexion.getConexion();
			String sql = "SELECT * FROM proveedores";
			statement = connection.prepareStatement(sql);
			resultSet = statement.executeQuery();
			while (resultSet.next()) {
				ProveedorVO proveedor = new ProveedorVO();
				proveedor.setId(resultSet.getInt("id"));
				proveedor.setNombre(resultSet.getString("nombre"));
				proveedor.setDireccion(resultSet.getString("direccion"));
				proveedor.setLocalidad(resultSet.getString("localidad"));
				proveedor.setProvincia(resultSet.getString("provincia"));
				proveedor.setTelefono(resultSet.getString("telefono"));
				proveedor.setCif(resultSet.getString("cif"));
				proveedor.setEmail(resultSet.getString("email"));
				proveedor.setBaja(resultSet.getBoolean("baja"));
				proveedores.add(proveedor);
			}
		} catch (SQLException e) {
			e.printStackTrace();
		}
		return proveedores;
	}
	
	public static ProveedorVO getProveedorPorId(int id) {
	    Connection connection = null;
	    PreparedStatement statement = null;
	    ResultSet resultSet = null;
	    ProveedorVO proveedor = null;
	    try {
	        connection = Conexion.getConexion();
	        String sql = "SELECT * FROM proveedores WHERE id = ?";
	        statement = connection.prepareStatement(sql);
	        statement.setInt(1, id);
	        resultSet = statement.executeQuery();
	        if (resultSet.next()) {
	            proveedor = new ProveedorVO();
	            proveedor.setId(resultSet.getInt("id"));
	            proveedor.setNombre(resultSet.getString("nombre"));
	            proveedor.setDireccion(resultSet.getString("direccion"));
	            proveedor.setLocalidad(resultSet.getString("localidad"));
	            proveedor.setProvincia(resultSet.getString("provincia"));
	            proveedor.setTelefono(resultSet.getString("telefono"));
	            proveedor.setCif(resultSet.getString("cif"));
	            proveedor.setEmail(resultSet.getString("email"));
	            proveedor.setBaja(resultSet.getBoolean("baja"));
	        }
	    } catch (SQLException e) {
	        e.printStackTrace();
	    }
	    return proveedor;
	}

	public static boolean actualizarBaja(int id, boolean baja) {
	    Connection con = null;
	    PreparedStatement st = null;
	    try {
	        con = Conexion.getConexion();
	        String sql = "UPDATE proveedores SET baja = ? WHERE id = ?";
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

}
