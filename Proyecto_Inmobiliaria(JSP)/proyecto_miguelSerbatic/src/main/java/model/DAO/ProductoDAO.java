package model.DAO;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.List;

import conexion.Conexion;
import model.VO.*;
import service.ProductoServicio;

import java.io.File;
import java.io.IOException;
import java.sql.Timestamp;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Date;

import jxl.Cell;
import jxl.Sheet;
import jxl.Workbook;
import jxl.read.biff.BiffException;

public class ProductoDAO {

	public static List<ProductoVO> getProductos() {

		List<ProductoVO> lista = new ArrayList<ProductoVO>();
		try {
			Connection con = Conexion.getConexion();
			PreparedStatement st = con.prepareStatement("SELECT * from productos");

			ResultSet rs = st.executeQuery();

			while (rs.next()) {
				ProductoVO producto = new ProductoVO();

				producto.setId(rs.getInt("id"));
				producto.setNombre(rs.getString("nombre"));
				producto.setDescripcion(rs.getString("descripcion"));
				producto.setPrecio(rs.getDouble("precio"));
				producto.setStock(rs.getInt("stock"));
				producto.setImpuestos(rs.getDouble("impuesto"));
				producto.setImagen(rs.getString("imagen"));
				producto.setFechaAlta(rs.getTimestamp("fecha_alta"));
				producto.setIdCategoria(rs.getInt("id_categoria"));
				producto.setBaja(rs.getBoolean("baja"));
				lista.add(producto);
			}

		} catch (SQLException e) {
			e.printStackTrace();
		}

		return lista;
	}
	
	public static List<ProductoVO> getProductosActivos() {

		List<ProductoVO> lista = new ArrayList<ProductoVO>();
		try {
			Connection con = Conexion.getConexion();
			PreparedStatement st = con.prepareStatement("SELECT * from productos WHERE baja = false");

			ResultSet rs = st.executeQuery();

			while (rs.next()) {
				ProductoVO producto = new ProductoVO();

				producto.setId(rs.getInt("id"));
				producto.setNombre(rs.getString("nombre"));
				producto.setDescripcion(rs.getString("descripcion"));
				producto.setPrecio(rs.getDouble("precio"));
				producto.setStock(rs.getInt("stock"));
				producto.setImpuestos(rs.getDouble("impuesto"));
				producto.setImagen(rs.getString("imagen"));
				producto.setFechaAlta(rs.getTimestamp("fecha_alta"));
				producto.setIdCategoria(rs.getInt("id_categoria"));
				producto.setBaja(rs.getBoolean("baja"));
				lista.add(producto);
			}

		} catch (SQLException e) {
			e.printStackTrace();
		}

		return lista;
	}

	public static boolean actualizarStock(int idProducto, int nuevoStock) {
		Connection con = null;
		PreparedStatement st = null;
		try {
			con = Conexion.getConexion();
			String sql = "UPDATE productos SET stock = ? WHERE id = ?";
			st = con.prepareStatement(sql);
			st.setInt(1, nuevoStock);
			st.setInt(2, idProducto);
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

	public static boolean actualizarBaja(int idProducto, boolean baja) {
		Connection con = null;
		PreparedStatement st = null;
		try {
			con = Conexion.getConexion();
			String sql = "UPDATE productos SET baja = ? WHERE id = ?";
			st = con.prepareStatement(sql);
			st.setBoolean(1, baja);
			st.setInt(2, idProducto);
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

	public static List<ProductoVO> getProductosPorCategoria(String categoria) {
		List<ProductoVO> lista = new ArrayList<>();
		try {
			Connection con = Conexion.getConexion();
			String query = "SELECT * FROM productos WHERE id_categoria = (SELECT id FROM categorias WHERE nombre = ?) AND baja = false";
			PreparedStatement st = con.prepareStatement(query);
			st.setString(1, categoria);
			ResultSet rs = st.executeQuery();

			while (rs.next()) {
				ProductoVO producto = new ProductoVO();
				producto.setId(rs.getInt("id"));
				producto.setNombre(rs.getString("nombre"));
				producto.setDescripcion(rs.getString("descripcion"));
				producto.setPrecio(rs.getDouble("precio"));
				producto.setStock(rs.getInt("stock"));
				producto.setImpuestos(rs.getDouble("impuesto"));
				producto.setImagen(rs.getString("imagen"));
				producto.setFechaAlta(rs.getTimestamp("fecha_alta"));
				producto.setIdCategoria(rs.getInt("id_categoria"));
				producto.setBaja(rs.getBoolean("baja"));

				lista.add(producto);
			}
		} catch (SQLException e) {
			e.printStackTrace();
		}
		return lista;
	}

//	public static List<Productos> getProductosHibernate() {
//		try (Session session = HibernateUtil.getSessionFactory().openSession()) {
//			return session.createQuery("FROM Producto", Productos.class).getResultList();
//		} catch (Exception e) {
//			e.printStackTrace();
//		}
//		return null;
//	}
//
//	public static List<Productos> getProductosPorCategoriaHibernate(String categoria) {
//		try (Session session = HibernateUtil.getSessionFactory().openSession()) {
//			Query<Productos> query = session.createQuery(
//					"SELECT p FROM Producto p JOIN p.categorias c WHERE c.nombre = :categorias", Productos.class);
//			query.setParameter("categorias", categoria);
//			return query.getResultList();
//		} catch (Exception e) {
//			e.printStackTrace();
//		}
//		return null;
//	}

	public static ProductoVO obtenerPorId(int id) {
		ProductoVO producto = null;
		try {
			Connection con = Conexion.getConexion();
			PreparedStatement st = con.prepareStatement("SELECT * FROM productos WHERE id = ?");
			st.setInt(1, id);

			ResultSet rs = st.executeQuery();

			if (rs.next()) {
				producto = new ProductoVO();
				producto.setId(rs.getInt("id"));
				producto.setNombre(rs.getString("nombre"));
				producto.setDescripcion(rs.getString("descripcion"));
				producto.setPrecio(rs.getDouble("precio"));
				producto.setStock(rs.getInt("stock"));
				producto.setImpuestos(rs.getDouble("impuesto"));
				producto.setImagen(rs.getString("imagen"));
				producto.setFechaAlta(rs.getTimestamp("fecha_alta"));
				producto.setIdCategoria(rs.getInt("id_categoria"));
				producto.setBaja(rs.getBoolean("baja"));
			}

		} catch (SQLException e) {
			e.printStackTrace();
		}
		return producto;
	}

	public static List<ProductoVO> getProductosPrecio(String orden) {
	    List<ProductoVO> lista = new ArrayList<>();
	    try {
	        Connection con = Conexion.getConexion();
	        String query = "SELECT * FROM productos WHERE baja = false ORDER BY precio " + orden;
	        PreparedStatement st = con.prepareStatement(query);
	        ResultSet rs = st.executeQuery();

	        while (rs.next()) {
	            ProductoVO producto = new ProductoVO();
	            producto.setId(rs.getInt("id"));
	            producto.setNombre(rs.getString("nombre"));
	            producto.setDescripcion(rs.getString("descripcion"));
	            producto.setPrecio(rs.getDouble("precio"));
	            producto.setStock(rs.getInt("stock"));
	            producto.setImpuestos(rs.getDouble("impuesto"));
	            producto.setImagen(rs.getString("imagen"));
	            producto.setIdCategoria(rs.getInt("id_categoria"));
	            producto.setBaja(rs.getBoolean("baja"));

	            lista.add(producto);
	        }
	    } catch (SQLException e) {
	        e.printStackTrace();
	    }
	    return lista;
	}


	public static List<ProductoVO> getProductosNuevos() {
		List<ProductoVO> lista = new ArrayList<>();
		try {
			Connection con = Conexion.getConexion();
			String query = "SELECT * FROM productos WHERE baja = false ORDER BY fecha_alta DESC";
			PreparedStatement st = con.prepareStatement(query);
			ResultSet rs = st.executeQuery();

			while (rs.next()) {
				ProductoVO producto = new ProductoVO();
				producto.setId(rs.getInt("id"));
				producto.setNombre(rs.getString("nombre"));
				producto.setDescripcion(rs.getString("descripcion"));
				producto.setPrecio(rs.getDouble("precio"));
				producto.setStock(rs.getInt("stock"));
				producto.setImpuestos(rs.getDouble("impuesto"));
				producto.setImagen(rs.getString("imagen"));
				producto.setIdCategoria(rs.getInt("id_categoria"));
				producto.setBaja(rs.getBoolean("baja"));

				lista.add(producto);
			}
		} catch (SQLException e) {
			e.printStackTrace();
		}
		return lista;
	}

	public static List<ProductoVO> getProductosMasVendidos() {
		List<ProductoVO> lista = new ArrayList<>();
		try {
			Connection con = Conexion.getConexion();
			String sql = "SELECT p.*, COUNT(d.id_producto) AS total_veces FROM productos p "
					+ "LEFT JOIN detalles_pedido d ON p.id = d.id_producto WHERE p.baja = false " + "GROUP BY p.id "
					+ "ORDER BY total_veces DESC";
			PreparedStatement st = con.prepareStatement(sql);

			ResultSet rs = st.executeQuery();

			while (rs.next()) {
				ProductoVO producto = new ProductoVO();

				producto.setId(rs.getInt("id"));
				producto.setNombre(rs.getString("nombre"));
				producto.setDescripcion(rs.getString("descripcion"));
				producto.setPrecio(rs.getDouble("precio"));
				producto.setStock(rs.getInt("stock"));
				producto.setImpuestos(rs.getDouble("impuesto"));
				producto.setImagen(rs.getString("imagen"));
				producto.setIdCategoria(rs.getInt("id_categoria"));
				producto.setBaja(rs.getBoolean("baja"));

				lista.add(producto);
			}
		} catch (SQLException e) {
			e.printStackTrace();
		}

		return lista;
	}

	public static boolean insertarProducto(ProductoVO producto) {
		try {
			Connection con = Conexion.getConexion();
			PreparedStatement ps = con.prepareStatement(
					"INSERT INTO productos (id_categoria, nombre, descripcion, precio, stock, impuesto, imagen) VALUES (?, ?, ?, ?, ?, ?, ?)");
			ps.setInt(1, producto.getIdCategoria());
			ps.setString(2, producto.getNombre());
			ps.setString(3, producto.getDescripcion());
			ps.setDouble(4, producto.getPrecio());
			ps.setInt(5, producto.getStock());
			ps.setDouble(6, producto.getImpuestos());
			ps.setString(7, producto.getImagen());
			int filasInsertadas = ps.executeUpdate();
			if (filasInsertadas > 0) {
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

	public static boolean editarProducto(ProductoVO producto) {
		Connection con = Conexion.getConexion();
		String sql = "UPDATE productos SET id_categoria=?, nombre=?, descripcion=?, precio=?, stock=?, impuesto=?, imagen=? WHERE id=?";
		try {
			PreparedStatement ps = con.prepareStatement(sql);
			ps.setInt(1, producto.getIdCategoria());
			ps.setString(2, producto.getNombre());
			ps.setString(3, producto.getDescripcion());
			ps.setDouble(4, producto.getPrecio());
			ps.setInt(5, producto.getStock());
			ps.setDouble(6, producto.getImpuestos());
			ps.setString(7, producto.getImagen());
			ps.setInt(8, producto.getId());
			int filasInsertadas = ps.executeUpdate();
			if (filasInsertadas > 0) {
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

	public static void insertProductsIntoDatabase(List<ProductoVO> productos) {
		Connection con = Conexion.getConexion();
		try {
			String sql = "INSERT INTO productos (nombre, descripcion, precio, stock, impuesto, imagen, fecha_alta, id_categoria, baja) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?)";
			PreparedStatement st = con.prepareStatement(sql);

			for (ProductoVO producto : productos) {
				st.setString(1, producto.getNombre());
				st.setString(2, producto.getDescripcion());
				st.setDouble(3, producto.getPrecio());
				st.setInt(4, producto.getStock());
				st.setDouble(5, producto.getImpuestos());
				st.setString(6, producto.getImagen());
				st.setTimestamp(7, producto.getFechaAlta());
				st.setInt(8, producto.getIdCategoria());
				st.setBoolean(9, producto.isBaja());

				st.executeUpdate();
				con.commit();
			}
		} catch (SQLException e) {
			e.printStackTrace();
		}
	}

}
