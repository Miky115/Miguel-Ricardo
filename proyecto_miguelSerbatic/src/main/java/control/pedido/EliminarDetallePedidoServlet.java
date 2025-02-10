package control.pedido;

import java.io.IOException;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import model.DAO.DetallesPedidoDAO;

@WebServlet("/eliminarLinea")
public class EliminarDetallePedidoServlet extends HttpServlet {
	private static final long serialVersionUID = 1L;

    public EliminarDetallePedidoServlet() {
        super();
    }

    protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
        int idDetallePedido = Integer.parseInt(request.getParameter("id"));
        int idPedido = DetallesPedidoDAO.obtenerIdPedido(idDetallePedido);
        DetallesPedidoDAO.eliminarDetallePedido(idDetallePedido);
        response.sendRedirect("PedidosDESC");
    }


	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		doGet(request, response);
	}

}
