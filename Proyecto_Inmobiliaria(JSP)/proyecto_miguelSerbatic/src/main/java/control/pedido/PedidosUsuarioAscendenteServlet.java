package control.pedido;

import java.io.IOException;
import java.util.ArrayList;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import model.DAO.PedidoDAO;
import model.VO.PedidoVO;
import model.VO.UsuarioVO;
import org.apache.log4j.Logger;
import org.apache.log4j.PropertyConfigurator;

@WebServlet("/PedidosASC")
public class PedidosUsuarioAscendenteServlet extends HttpServlet {
    private static final long serialVersionUID = 1L;
    private static Logger log = Logger.getLogger(PedidosUsuarioAscendenteServlet.class);

    public PedidosUsuarioAscendenteServlet() {
        super();
    }

    protected void doGet(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
		String log4jPath = getServletContext().getRealPath("/") + "ficheros/log4j.properties";
		PropertyConfigurator.configure(log4jPath);
        
        try {
            UsuarioVO usuario = (UsuarioVO) request.getSession().getAttribute("usuarioGuardado");
            if (usuario == null) {
                log.error("El usuario no ha iniciado sesión.");
                response.sendRedirect("iniciarSesion.jsp");
                return;
            }
            
            int id = usuario.getId();
            ArrayList<PedidoVO> pedidos = PedidoDAO.getPedidosUsuarioFecha(id, "ASC");
            request.setAttribute("pedidos", pedidos);
            request.getRequestDispatcher("misPedidos.jsp").forward(request, response);
        } catch (Exception e) {
            log.error("Error al obtener los pedidos del usuario en orden ascendente: " + e.getMessage());
            response.sendRedirect("error.jsp");
        }
    }

    protected void doPost(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        doGet(request, response);
    }
}
