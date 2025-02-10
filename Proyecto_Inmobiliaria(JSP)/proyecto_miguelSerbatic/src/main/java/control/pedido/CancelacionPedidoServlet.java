package control.pedido;

import java.io.IOException;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import model.DAO.PedidoDAO;
import org.apache.log4j.Logger;
import org.apache.log4j.PropertyConfigurator;

@WebServlet("/cancelar")
public class CancelacionPedidoServlet extends HttpServlet {
	private static final long serialVersionUID = 1L;
	private static Logger log = Logger.getLogger(CancelacionPedidoServlet.class);

	public CancelacionPedidoServlet() {
		super();
	}

	protected void doGet(HttpServletRequest request, HttpServletResponse response)
			throws ServletException, IOException {
		String log4jPath = getServletContext().getRealPath("/") + "ficheros/log4j.properties";
		PropertyConfigurator.configure(log4jPath);

		try {
			String referer = request.getHeader("referer");
			if (referer == null) {
				log.error("Error: No se pudo obtener el referer.");
				response.sendRedirect("error.jsp");
				return;
			}

			String idParam = request.getParameter("id");
			if (idParam == null) {
				log.error("Error: No se proporcionó un ID para cancelar el pedido.");
				response.sendRedirect("error.jsp");
				return;
			}

			int id = Integer.parseInt(idParam);
			PedidoDAO.cancelarPedido(id, "cancelado");
			response.sendRedirect(referer);
		} catch (NumberFormatException e) {
			log.error("Error: El ID del pedido no es válido.", e);
			response.sendRedirect("error.jsp");
		} catch (Exception e) {
			log.error("Error al cancelar el pedido: " + e.getMessage());
			response.sendRedirect("error.jsp");
		}
	}

	protected void doPost(HttpServletRequest request, HttpServletResponse response)
			throws ServletException, IOException {
		doGet(request, response);
	}
}
