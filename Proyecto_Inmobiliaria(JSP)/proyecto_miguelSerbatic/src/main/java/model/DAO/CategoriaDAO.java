package model.DAO;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.List;

import conexion.Conexion;
import model.VO.CategoriaVO;

public class CategoriaDAO {

	public static boolean insertCategoria(CategoriaVO categoria) {
		Connection connection = null;
		PreparedStatement statement = null;
		boolean inserted = false;
		try {
			connection = Conexion.getConexion();
			String sql = "INSERT INTO categorias (nombre, descripcion) VALUES (?, ?)";
			statement = connection.prepareStatement(sql);
			statement.setString(1, categoria.getNombre());
			statement.setString(2, categoria.getDescripcion());
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

	public static boolean updateCategoria(CategoriaVO categoria) {
		Connection connection = null;
		PreparedStatement statement = null;
		boolean updated = false;
		try {
			connection = Conexion.getConexion();
			String sql = "UPDATE categorias SET nombre = ?, descripcion = ? WHERE id = ?";
			statement = connection.prepareStatement(sql);
			statement.setString(1, categoria.getNombre());
			statement.setString(2, categoria.getDescripcion());
			statement.setInt(3, categoria.getId());
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

	public static boolean deleteCategoria(int id) {
		Connection connection = null;
		PreparedStatement statement = null;
		boolean deleted = false;
		try {
			connection = Conexion.getConexion();
			String sql = "DELETE FROM categorias WHERE id = ?";
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

	public static List<CategoriaVO> selectCategorias() {
		List<CategoriaVO> categorias = new ArrayList<>();
		Connection connection = null;
		PreparedStatement statement = null;
		ResultSet resultSet = null;
		try {
			connection = Conexion.getConexion();
			String sql = "SELECT * FROM categorias";
			statement = connection.prepareStatement(sql);
			resultSet = statement.executeQuery();
			while (resultSet.next()) {
				CategoriaVO categoria = new CategoriaVO();
				categoria.setId(resultSet.getInt("id"));
				categoria.setNombre(resultSet.getString("nombre"));
				categoria.setDescripcion(resultSet.getString("descripcion"));
				categorias.add(categoria);
			}
		} catch (SQLException e) {
			e.printStackTrace();
		}
		return categorias;
	}

	public static CategoriaVO obtenerPorId(int id) {
		Connection connection = null;
		PreparedStatement statement = null;
		ResultSet resultSet = null;
		CategoriaVO categoria = null;
		try {
			connection = Conexion.getConexion();
			String sql = "SELECT * FROM categorias WHERE id = ?";
			statement = connection.prepareStatement(sql);
			statement.setInt(1, id);
			resultSet = statement.executeQuery();
			if (resultSet.next()) {
				categoria = new CategoriaVO();
				categoria.setId(resultSet.getInt("id"));
				categoria.setNombre(resultSet.getString("nombre"));
				categoria.setDescripcion(resultSet.getString("descripcion"));
			}
		} catch (SQLException e) {
			e.printStackTrace();
		}
		return categoria;
	}
}
