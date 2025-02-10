package model.DAO;

import java.nio.file.spi.FileSystemProvider;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Timestamp;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

import conexion.Conexion;
import model.VO.DetallesPedidoVO;
import model.VO.PedidoVO;
import model.VO.ProductoVO;
import model.VO.UsuarioVO;

public class DetallesPedidoDAO {

	public static boolean insertarDetallesPedido(HashMap<ProductoVO, Integer> carrito) {
	    try {
	        Connection con = Conexion.getConexion();
	        String sql = "INSERT INTO detalles_pedido (id_pedido, id_producto, precio_unidad, unidades, impuesto, total) VALUES (?,?,?,?,?,?)";
	        PreparedStatement st = con.prepareStatement(sql);

	        for (Map.Entry<ProductoVO, Integer> entry : carrito.entrySet()) {
	            ProductoVO producto = entry.getKey();
	            Integer cantidad = entry.getValue();
	            PedidoVO pedido = PedidoDAO.getUltimoPedido();
	            System.out.println(producto.getNombre());

	            double precioTotal = producto.getPrecio() * cantidad;
	            double impuesto = producto.getPrecio() * producto.getImpuestos() * cantidad;
	            double total = precioTotal + impuesto;

	            st.setInt(1, pedido.getId());
	            st.setInt(2, producto.getId());
	            st.setDouble(3, producto.getPrecio());
	            st.setInt(4, cantidad);
	            st.setDouble(5, impuesto);
	            st.setDouble(6, total);

				int filasInsertadas = st.executeUpdate();
				if (filasInsertadas > 0) {
					con.commit();
					System.out.println("filas insertadas detalle: "+filasInsertadas);
				} else {
					System.out.println("no fue");
				}

	            ProductoDAO.actualizarStock(producto.getId(), producto.getStock() - cantidad);
	        }
	        return true;
	    } catch (SQLException e) {
	        e.printStackTrace();
	    }
	    return false;
	}


	public static double getTotal() {

		PedidoVO pedido = PedidoDAO.getUltimoPedido();
		double total = 0;
		PreparedStatement statement = null;
		Connection connection = Conexion.getConexion();
		String sql = "SELECT total FROM detalles_pedido WHERE id_pedido = ?";
		try {
			statement = connection.prepareStatement(sql);
			statement.setInt(1, pedido.getId());
			ResultSet rs = statement.executeQuery();

			while (rs.next()) {
				total += rs.getDouble("total");
				System.out.println("total = "+total);
			}
		} catch (SQLException e) {
			e.printStackTrace();
		}
		return total;
	}

	public static ArrayList<DetallesPedidoVO> getDetallesPedido(int idPedido) {
		ArrayList<DetallesPedidoVO> detalles = new ArrayList<>();
		Connection connection = null;
		PreparedStatement statement = null;
		ResultSet rs = null;

		try {
			connection = Conexion.getConexion();
			String sql = "SELECT * FROM detalles_pedido WHERE id_pedido = ?";
			statement = connection.prepareStatement(sql);
			statement.setInt(1, idPedido);
			rs = statement.executeQuery();

			while (rs.next()) {
				DetallesPedidoVO detalle = new DetallesPedidoVO();
				detalle.setId(rs.getInt("id"));
				detalle.setIdPedido(rs.getInt("id_pedido"));
				detalle.setIdProducto(rs.getInt("id_producto"));
				detalle.setPrecioUnidad(rs.getDouble("precio_unidad"));
				detalle.setUnidades(rs.getInt("unidades"));
				detalle.setImpuesto(rs.getDouble("impuesto"));
				detalle.setTotal(rs.getDouble("total"));

				detalles.add(detalle);
			}
		} catch (SQLException e) {
			e.printStackTrace();
		}
		return detalles;
	}
	
	public static boolean eliminarDetallePedido(int idDetallePedido) {
	    Connection con = Conexion.getConexion();
	    try {
	        int idPedido = -1;
	        double totalDetallePedido = 0.0;

	        String obtenerIdPedidoSql = "SELECT id_pedido, total FROM detalles_pedido WHERE id = ?";
	        PreparedStatement obtenerIdPedidoSt = con.prepareStatement(obtenerIdPedidoSql);
	        obtenerIdPedidoSt.setInt(1, idDetallePedido);
	        ResultSet rs = obtenerIdPedidoSt.executeQuery();

	        if (rs.next()) {
	            idPedido = rs.getInt("id_pedido");
	            totalDetallePedido = rs.getDouble("total");
	        }

	        if (idPedido != -1) {
	            String eliminarDetallePedidoSql = "DELETE FROM detalles_pedido WHERE id = ?";
	            PreparedStatement eliminarDetallePedidoSt = con.prepareStatement(eliminarDetallePedidoSql);
	            eliminarDetallePedidoSt.setInt(1, idDetallePedido);
	            eliminarDetallePedidoSt.executeUpdate();

	            ArrayList<DetallesPedidoVO> detallesPedido = getDetallesPedido(idPedido);

	            double nuevoTotalPedido = 0.0;
	            for (DetallesPedidoVO detalle : detallesPedido) {
	                nuevoTotalPedido += detalle.getTotal();
	            }

	            String actualizarTotalPedidoSql = "UPDATE pedidos SET total = ? WHERE id = ?";
	            PreparedStatement actualizarTotalPedidoSt = con.prepareStatement(actualizarTotalPedidoSql);
	            actualizarTotalPedidoSt.setDouble(1, nuevoTotalPedido);
	            actualizarTotalPedidoSt.setInt(2, idPedido);
	            actualizarTotalPedidoSt.executeUpdate();

	            con.commit();

	            return true;
	        }
	    } catch (SQLException e) {
	        e.printStackTrace();
	    }
	    return false;
	}

	public static int obtenerIdPedido(int idDetallePedido) {
	    Connection con = Conexion.getConexion();
	    try {
	        String obtenerIdPedidoSql = "SELECT id_pedido FROM detalles_pedido WHERE id = ?";
	        PreparedStatement obtenerIdPedidoSt = con.prepareStatement(obtenerIdPedidoSql);
	        obtenerIdPedidoSt.setInt(1, idDetallePedido);
	        ResultSet rs = obtenerIdPedidoSt.executeQuery();

	        if (rs.next()) {
	            int idPedido = rs.getInt("id_pedido");
	            rs.close();
	            return idPedido;
	        }
	    } catch (SQLException e) {
	        e.printStackTrace();
	    }
	    return -1;
	}



}
