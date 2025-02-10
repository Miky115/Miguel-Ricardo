package model.DAO;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;

import conexion.Conexion;
import model.VO.ConfiguracionVO;
import model.VO.PedidoVO;

public class ConfiguracionDAO {

	public static boolean sumarValor() {
		boolean insercionExitosa = false;
		PreparedStatement statement = null;
		Connection connection = Conexion.getConexion();
		String sql = "UPDATE configuracion SET valor = ? WHERE id = 1";
		try {

			int nuevoValor = numValor() + 1;
			System.out.println(numValor());
			System.out.println(nuevoValor);

			statement = connection.prepareStatement(sql);

			statement.setString(1, String.valueOf(nuevoValor));

			int filasInsertadas = statement.executeUpdate();

			if (filasInsertadas > 0) {
				insercionExitosa = true;
				connection.commit();
				System.out.println("funcionó");
			} else {
				insercionExitosa = false;
			}

		} catch (SQLException e) {
			e.printStackTrace();
		}
		return insercionExitosa;
	}

	public static int numValor() {
		int num = 0;
		PreparedStatement statement = null;
		Connection connection = Conexion.getConexion();
		String sql = "SELECT valor FROM configuracion WHERE id = 1";
		try {
			statement = connection.prepareStatement(sql);
			ResultSet rs = statement.executeQuery();

			if (rs.next()) {
				num = Integer.parseInt(rs.getString("valor"));
			}
		} catch (SQLException e) {
			e.printStackTrace();
		}
		return num;
	}
	
	public static ConfiguracionVO getConfiguracion(String clave) {
		ConfiguracionVO configuracion = new ConfiguracionVO();
		PreparedStatement statement = null;
		Connection connection = Conexion.getConexion();
		String sql = "SELECT * FROM configuracion WHERE clave = ?";

		try {
			statement = connection.prepareStatement(sql);
			statement.setString(1, clave);
			ResultSet rs = statement.executeQuery();

			if (rs.next()) {
				configuracion.setId(rs.getInt("id"));
				configuracion.setClave(rs.getString("clave"));
				configuracion.setValor(rs.getString("valor"));
				configuracion.setTipo(rs.getString("tipo"));
			}
		} catch (SQLException e) {
			e.printStackTrace();
		}
		return configuracion;
	}
	
	public static void updateConfiguracion(String clave, String valor) {
	    Connection connection = null;
	    PreparedStatement statement = null;

	    try {
	        connection = Conexion.getConexion();
	        String sql = "UPDATE configuracion SET valor = ? WHERE clave = ?";
	        statement = connection.prepareStatement(sql);
	        statement.setString(1, valor);
	        statement.setString(2, clave);
	        
	        statement.executeUpdate();
	        connection.commit();

	    } catch (SQLException e) {
	        e.printStackTrace();
	    }
	}

}
