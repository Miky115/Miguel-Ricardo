package control.pedido;

import java.io.IOException;
import java.util.ArrayList;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import model.DAO.DetallesPedidoDAO;
import model.VO.DetallesPedidoVO;
import org.apache.log4j.Logger;
import org.apache.log4j.PropertyConfigurator;

@WebServlet("/DetallePedidoServlet")
public class DetallePedidoServlet extends HttpServlet {
	private static final long serialVersionUID = 1L;
	private static Logger log = Logger.getLogger(DetallePedidoServlet.class);

	public DetallePedidoServlet() {
		super();
	}

	protected void doGet(HttpServletRequest request, HttpServletResponse response)
			throws ServletException, IOException {
		String log4jPath = getServletContext().getRealPath("/") + "ficheros/log4j.properties";
		PropertyConfigurator.configure(log4jPath);

		try {
			String idParam = request.getParameter("id");
			if (idParam == null) {
				log.error("Error: No se proporcionó un ID para obtener los detalles del pedido.");
				response.sendRedirect("error.jsp");
				return;
			}

			int id = Integer.parseInt(idParam);
			ArrayList<DetallesPedidoVO> detalles = DetallesPedidoDAO.getDetallesPedido(id);
			request.setAttribute("detalles", detalles);
			request.getRequestDispatcher("detallePedidos.jsp").forward(request, response);
		} catch (NumberFormatException e) {
			log.error("Error: El ID del pedido no es válido.", e);
			response.sendRedirect("error.jsp");
		} catch (Exception e) {
			log.error("Error al obtener los detalles del pedido: " + e.getMessage());
			response.sendRedirect("error.jsp");
		}
	}

	protected void doPost(HttpServletRequest request, HttpServletResponse response)
			throws ServletException, IOException {
		doGet(request, response);
	}
}
