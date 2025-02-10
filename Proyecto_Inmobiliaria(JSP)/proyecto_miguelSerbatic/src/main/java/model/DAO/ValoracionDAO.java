package model.DAO;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.List;

import conexion.Conexion;
import model.VO.MostrarValoracionVO;

public class ValoracionDAO {
	public static boolean insertarValoracion(int idProducto, int idUsuario, int valoracion, String comentario) {
		Connection conn = Conexion.getConexion();
		PreparedStatement stmt = null;
		try {
			String sql = "INSERT INTO valoraciones (id_producto, id_usuario, valoracion, comentario) VALUES (?, ?, ?, ?)";
			stmt = conn.prepareStatement(sql);
			stmt.setInt(1, idProducto);
			stmt.setInt(2, idUsuario);
			stmt.setInt(3, valoracion);
			stmt.setString(4, comentario);

			int rows = stmt.executeUpdate();
			conn.commit();

			return rows > 0;

		} catch (SQLException e) {
			e.printStackTrace();
			return false;
		}
	}
	
    public static List<MostrarValoracionVO> getValoraciones() {
        Connection conn = Conexion.getConexion();
        PreparedStatement stmt = null;
        ResultSet rs = null;
        List<MostrarValoracionVO> valoraciones = new ArrayList<>();
        String sql = "SELECT u.nombre AS nombre_usuario, u.apellido1 AS apellido1_usuario, u.apellido2 AS apellido2_usuario, " +
                "p.nombre AS nombre_producto, v.valoracion, v.comentario " +
                "FROM valoraciones v " +
                "JOIN usuarios u ON v.id_usuario = u.id " +
                "JOIN productos p ON v.id_producto = p.id ORDER BY v.id DESC";
        try {
            stmt = conn.prepareStatement(sql);
            rs = stmt.executeQuery();
            while (rs.next()) {
                String nombreUsuario = rs.getString("nombre_usuario");
                String apellido1Usuario = rs.getString("apellido1_usuario");
                String apellido2Usuario = rs.getString("apellido2_usuario");
                String nombreProducto = rs.getString("nombre_producto");
                int valoracion = rs.getInt("valoracion");
                String comentario = rs.getString("comentario");
                MostrarValoracionVO valoracionObj = new MostrarValoracionVO(nombreUsuario, apellido1Usuario, apellido2Usuario, nombreProducto, valoracion, comentario);
                valoraciones.add(valoracionObj);
            }
        } catch (SQLException e) {
            e.printStackTrace();
        }
        return valoraciones;
    }
}
