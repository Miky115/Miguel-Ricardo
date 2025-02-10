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

@WebServlet("/peticionCancelacion")
public class PeticionCancelacionPedidoServlet extends HttpServlet {
    private static final long serialVersionUID = 1L;
    private static Logger log = Logger.getLogger(PeticionCancelacionPedidoServlet.class);

    public PeticionCancelacionPedidoServlet() {
        super();
    }

    protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		String log4jPath = getServletContext().getRealPath("/") + "ficheros/log4j.properties";
		PropertyConfigurator.configure(log4jPath);
        
        try {
            String referer = request.getHeader("referer");
            int id = Integer.parseInt(request.getParameter("id"));
            PedidoDAO.cancelarPedido(id, "pendiente cancelación");
            response.sendRedirect(referer);
        } catch (NumberFormatException e) {
            log.error("Error al procesar la petición de cancelación de pedido: " + e.getMessage());
            response.sendRedirect("error.jsp");
        } catch (Exception e) {
            log.error("Error al procesar la petición de cancelación de pedido: " + e.getMessage());
            response.sendRedirect("error.jsp");
        }
    }

    protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
        doGet(request, response);
    }
}
