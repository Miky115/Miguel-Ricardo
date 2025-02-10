package control.valoracion;

import java.io.IOException;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import model.DAO.ValoracionDAO;

@WebServlet("/valorarProducto")
public class InsertarValoracionServlet extends HttpServlet {
	private static final long serialVersionUID = 1L;

	public InsertarValoracionServlet() {
		super();
	}

	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		int idProducto = Integer.parseInt(request.getParameter("id_Producto"));
		int idUsuario = Integer.parseInt(request.getParameter("id_Usuario"));
		int valoracion = Integer.parseInt(request.getParameter("valoracion"));
		String comentario = request.getParameter("comentario");
		System.out.println(idProducto);
		System.out.println(idUsuario);
		System.out.println(valoracion);
		System.out.println(comentario);
		
		boolean insercionExitosa = ValoracionDAO.insertarValoracion(idProducto, idUsuario, valoracion, comentario);

		response.sendRedirect("PedidosDESC");
	}

}
