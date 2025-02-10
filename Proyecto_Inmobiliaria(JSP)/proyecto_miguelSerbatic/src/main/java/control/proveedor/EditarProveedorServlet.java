package control.proveedor;

import java.io.IOException;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import model.DAO.ProveedorDAO;
import model.VO.ProveedorVO;

import org.apache.log4j.Logger;
import org.apache.log4j.PropertyConfigurator;

@WebServlet("/editarProveedor")
public class EditarProveedorServlet extends HttpServlet {
    private static final long serialVersionUID = 1L;
    private static Logger log = Logger.getLogger(EditarProveedorServlet.class);

    public EditarProveedorServlet() {
        super();
    }

    protected void doGet(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        String log4jPath = getServletContext().getRealPath("/") + "ficheros/log4j.properties";
        PropertyConfigurator.configure(log4jPath);
        try {
            String id = request.getParameter("id");
            if (id != null && !id.isEmpty()) {
                ProveedorVO proveedor = ProveedorDAO.getProveedorPorId(Integer.parseInt(id));
                if (proveedor != null) {
                    request.setAttribute("proveedor", proveedor);
                    request.getSession().setAttribute("id", id);
                    request.getRequestDispatcher("editarProveedor.jsp").forward(request, response);
                } else {
                    response.sendRedirect("error.jsp");
                }
            } else {
                response.sendRedirect("error.jsp");
            }
        } catch (Exception e) {
            log.error("Error al obtener el proveedor para editar: " + e.getMessage());
            response.sendRedirect("error.jsp");
        }
    }


    protected void doPost(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        try {
            String nombre = request.getParameter("nombre");
            String direccion = request.getParameter("direccion");
            String localidad = request.getParameter("localidad");
            String provincia = request.getParameter("provincia");
            String telefono = request.getParameter("telefono");
            String cif = request.getParameter("cif");
            String email = request.getParameter("email");
            String idStr = (String) request.getSession().getAttribute("id");
            
            if (idStr != null && !idStr.isEmpty()) {
                int id = Integer.parseInt(idStr);
                ProveedorVO proveedor = new ProveedorVO(id, nombre, direccion, localidad, provincia, telefono, cif, email, false);
				ProveedorDAO.updateProveedor(proveedor);
                request.getSession().setAttribute("id", null);
                response.sendRedirect("mostrarProveedores");
            } else {
                response.sendRedirect("error.jsp");
            }
        } catch (Exception e) {
            log.error("Error al editar el proveedor: " + e.getMessage());
            response.sendRedirect("error.jsp");
        }
    }

}
