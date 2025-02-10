package model.DAO;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Timestamp;
import java.util.ArrayList;
import java.util.List;

import conexion.Conexion;
import model.VO.PedidoVO;
import model.VO.UsuarioVO;

public class PedidoDAO {
	public static boolean insertarPedido(String email, String metodoPago) {
		Connection connection = Conexion.getConexion();
		PreparedStatement statement = null;
		boolean insercionExitosa = false;
		UsuarioVO usuario = UsuarioDAO.getUsuario(email);
		String sql = "INSERT INTO pedidos (id_usuario, fecha, estado, num_factura, metodo_pago) VALUES (?,?,?,?,?)";

		try {

			statement = connection.prepareStatement(sql);
			statement.setInt(1, usuario.getId());
			statement.setTimestamp(2, new Timestamp(System.currentTimeMillis()));
			statement.setString(3, "pendiente envío");
			statement.setString(4, "esperando al envio...");
			statement.setString(5, metodoPago);

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

	public static PedidoVO getUltimoPedido() {

		PedidoVO pedido = new PedidoVO();
		PreparedStatement statement = null;
		Connection connection = Conexion.getConexion();
		String sql = "SELECT * FROM pedidos ORDER BY id DESC LIMIT 1";
		try {
			statement = connection.prepareStatement(sql);
			ResultSet rs = statement.executeQuery();

			if (rs.next()) {
				pedido.setId(rs.getInt("id"));
				pedido.setIdUsuario(rs.getInt("id_usuario"));
				pedido.setFecha(rs.getTimestamp("fecha"));
				pedido.setMetodoPago(rs.getString("metodo_pago"));
				pedido.setEstado(rs.getString("estado"));
				pedido.setNumFactura(rs.getString("num_factura"));
				pedido.setTotal(rs.getDouble("total"));

				return pedido;
			} else {
				return null;
			}
		} catch (SQLException e) {
			e.printStackTrace();
		}
		return null;
	}

	public static boolean insertarTotalPedido() {
		Connection connection = Conexion.getConexion();
		PreparedStatement statement = null;
		boolean insercionExitosa = false;
		String sql = "UPDATE pedidos SET total = ? WHERE id = ?";

		try {

			statement = connection.prepareStatement(sql);
			statement.setDouble(1, DetallesPedidoDAO.getTotal());
			statement.setInt(2, getUltimoPedido().getId());

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

	public static boolean cancelarPedido(int idUsuario, String estado) {
		PreparedStatement statement = null;
		Connection connection = Conexion.getConexion();
		boolean insercionExitosa = false;
		String sql = "UPDATE pedidos SET estado = ?, num_factura = ? WHERE id = ?";
		try {
			statement = connection.prepareStatement(sql);
			statement.setString(1, estado);
			statement.setString(2, " ");
			statement.setInt(3, idUsuario);

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

	public static boolean enviarPedido(int idUsuario) {
		PreparedStatement statement = null;
		Connection connection = Conexion.getConexion();
		boolean insercionExitosa = false;
		String sql = "UPDATE pedidos SET estado = ?, num_factura = ? WHERE id = ?";
		try {
			statement = connection.prepareStatement(sql);
			statement.setString(1, "enviado");
			statement.setString(2, "FA00" + String.valueOf(ConfiguracionDAO.numValor()));
			statement.setInt(3, idUsuario);

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

	public static ArrayList<PedidoVO> getPedidosUsuario(int idUsuario) {
		ArrayList<PedidoVO> pedidos = new ArrayList<>();
		PreparedStatement statement = null;
		Connection connection = Conexion.getConexion();
		String sql = "SELECT * FROM pedidos WHERE id_usuario = ?";
		try {
			statement = connection.prepareStatement(sql);
			statement.setInt(1, idUsuario);
			ResultSet rs = statement.executeQuery();

			while (rs.next()) {
				PedidoVO pedido = new PedidoVO();
				pedido.setId(rs.getInt("id"));
				pedido.setIdUsuario(rs.getInt("id_usuario"));
				pedido.setFecha(rs.getTimestamp("fecha"));
				pedido.setMetodoPago(rs.getString("metodo_pago"));
				pedido.setEstado(rs.getString("estado"));
				pedido.setNumFactura(rs.getString("num_factura"));
				pedido.setTotal(rs.getDouble("total"));

				pedidos.add(pedido);
			}
		} catch (SQLException e) {
			e.printStackTrace();
		}
		return pedidos;
	}

	public static ArrayList<PedidoVO> getPedidos() {
		ArrayList<PedidoVO> pedidos = new ArrayList<>();
		PreparedStatement statement = null;
		Connection connection = Conexion.getConexion();
		String sql = "SELECT * FROM pedidos";
		try {
			statement = connection.prepareStatement(sql);
			ResultSet rs = statement.executeQuery();

			while (rs.next()) {
				PedidoVO pedido = new PedidoVO();
				pedido.setId(rs.getInt("id"));
				pedido.setIdUsuario(rs.getInt("id_usuario"));
				pedido.setFecha(rs.getTimestamp("fecha"));
				pedido.setMetodoPago(rs.getString("metodo_pago"));
				pedido.setEstado(rs.getString("estado"));
				pedido.setNumFactura(rs.getString("num_factura"));
				pedido.setTotal(rs.getDouble("total"));

				pedidos.add(pedido);
			}
		} catch (SQLException e) {
			e.printStackTrace();
		}
		return pedidos;
	}
	
	public static PedidoVO getPedido(int id) {
        PedidoVO pedido = null;
        PreparedStatement statement = null;
        Connection connection = Conexion.getConexion();
        String sql = "SELECT * FROM pedidos WHERE id = ?";
        try {
            statement = connection.prepareStatement(sql);
            statement.setInt(1, id);
            ResultSet rs = statement.executeQuery();

            if (rs.next()) {
                pedido = new PedidoVO();
                pedido.setId(rs.getInt("id"));
                pedido.setIdUsuario(rs.getInt("id_usuario"));
                pedido.setFecha(rs.getTimestamp("fecha"));
                pedido.setMetodoPago(rs.getString("metodo_pago"));
                pedido.setEstado(rs.getString("estado"));
                pedido.setNumFactura(rs.getString("num_factura"));
                pedido.setTotal(rs.getDouble("total"));
            }
        } catch (SQLException e) {
            e.printStackTrace();
        }
        return pedido;
    }

	public static ArrayList<PedidoVO> getPedidosUsuarioFecha(int idUsuario, String fecha) {
		ArrayList<PedidoVO> pedidos = new ArrayList<>();
		PreparedStatement statement = null;
		Connection connection = Conexion.getConexion();
		String sql = "SELECT * FROM pedidos WHERE id_usuario = ? ORDER BY fecha " + fecha;
		try {
			statement = connection.prepareStatement(sql);
			statement.setInt(1, idUsuario);
			ResultSet rs = statement.executeQuery();

			while (rs.next()) {
				PedidoVO pedido = new PedidoVO();
				pedido.setId(rs.getInt("id"));
				pedido.setIdUsuario(rs.getInt("id_usuario"));
				pedido.setFecha(rs.getTimestamp("fecha"));
				pedido.setMetodoPago(rs.getString("metodo_pago"));
				pedido.setEstado(rs.getString("estado"));
				pedido.setNumFactura(rs.getString("num_factura"));
				pedido.setTotal(rs.getDouble("total"));

				pedidos.add(pedido);
			}
		} catch (SQLException e) {
			e.printStackTrace();
		}
		return pedidos;
	}

	public static ArrayList<PedidoVO> getUltimosPedidosPorDia(int cantidad) {
		ArrayList<PedidoVO> pedidos = new ArrayList<>();
		PreparedStatement statement = null;
		Connection connection = Conexion.getConexion();

		String sql = "SELECT DATE(fecha) AS fecha, SUM(total) AS total FROM pedidos WHERE estado = 'enviado' GROUP BY DATE(fecha) ORDER BY fecha DESC LIMIT ?";

		try {
			statement = connection.prepareStatement(sql);
			statement.setInt(1, cantidad);

			ResultSet rs = statement.executeQuery();

			while (rs.next()) {
				PedidoVO pedido = new PedidoVO();
				pedido.setFecha(rs.getTimestamp("fecha"));
				pedido.setTotal(rs.getDouble("total"));

				pedidos.add(pedido);
			}
		} catch (SQLException e) {
			e.printStackTrace();
		}
		return pedidos;
	}

	public static List<PedidoVO> getPedidosPendientes() {
		List<PedidoVO> pedidosPendientes = new ArrayList<>();
		PreparedStatement statement = null;
		Connection connection = Conexion.getConexion();

		String sql = "SELECT * FROM pedidos WHERE estado = ?";

		try {
			statement = connection.prepareStatement(sql);
			statement.setString(1, "pendiente envío");
			ResultSet resultSet = statement.executeQuery();

			while (resultSet.next()) {
				PedidoVO pedido = new PedidoVO();
				pedido.setId(resultSet.getInt("id"));
				pedidosPendientes.add(pedido);
			}
		} catch (SQLException e) {
			e.printStackTrace();
		}
		return pedidosPendientes;
	}
	
	public static String NumFactura(int id) {
	    String NumFactura = "";
	    PreparedStatement statement = null;
	    Connection connection = Conexion.getConexion();
	    String sql = "SELECT num_factura FROM pedidos WHERE id = ?";

	    try {
	        statement = connection.prepareStatement(sql);
	        statement.setInt(1, id);
	        ResultSet rs = statement.executeQuery();

	        if (rs.next()) {
	            NumFactura = rs.getString("num_factura");
	            return NumFactura;
	        }
	    } catch (SQLException e) {
	        e.printStackTrace();
	    }
	    return NumFactura;
	}

}
