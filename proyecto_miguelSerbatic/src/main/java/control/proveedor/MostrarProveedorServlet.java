package control.proveedor;

import java.io.IOException;
import java.util.List;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import model.DAO.ProveedorDAO;
import model.VO.ProveedorVO;

import org.apache.log4j.Logger;
import org.apache.log4j.PropertyConfigurator;

@WebServlet("/mostrarProveedores")
public class MostrarProveedorServlet extends HttpServlet {
    private static final long serialVersionUID = 1L;
    private static Logger log = Logger.getLogger(MostrarProveedorServlet.class);

    public MostrarProveedorServlet() {
        super();
    }

    protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
        String log4jPath = getServletContext().getRealPath("/") + "ficheros/log4j.properties";
        PropertyConfigurator.configure(log4jPath);
        try {
            List<ProveedorVO> proveedores = ProveedorDAO.getProveedores();
            request.setAttribute("proveedores", proveedores);
            request.getRequestDispatcher("gestionProveedores.jsp").forward(request, response);
        } catch (Exception e) {
            log.error("Error al obtener los proveedores: " + e.getMessage());
            response.sendRedirect("error.jsp");
        }
    }


    protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
        doGet(request, response);
    }
}
