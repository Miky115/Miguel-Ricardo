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

@WebServlet("/crearProveedor")
public class CrearProveedorServlet extends HttpServlet {
    private static final long serialVersionUID = 1L;
    private static Logger log = Logger.getLogger(CrearProveedorServlet.class);

    public CrearProveedorServlet() {
        super();
    }

    protected void doPost(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        String log4jPath = getServletContext().getRealPath("/") + "ficheros/log4j.properties";
        PropertyConfigurator.configure(log4jPath);
        try {
            String nombre = request.getParameter("nombre");
            String direccion = request.getParameter("direccion");
            String localidad = request.getParameter("localidad");
            String provincia = request.getParameter("provincia");
            String telefono = request.getParameter("telefono");
            String cif = request.getParameter("cif");
            String email = request.getParameter("email");

            if (nombre != null && !nombre.isEmpty() && direccion != null && !direccion.isEmpty()
                    && localidad != null && !localidad.isEmpty() && provincia != null && !provincia.isEmpty()
                    && telefono != null && !telefono.isEmpty() && cif != null && !cif.isEmpty()
                    && email != null && !email.isEmpty()) {
                ProveedorVO proveedor = new ProveedorVO();
                proveedor.setNombre(nombre);
                proveedor.setDireccion(direccion);
                proveedor.setLocalidad(localidad);
                proveedor.setProvincia(provincia);
                proveedor.setTelefono(telefono);
                proveedor.setCif(cif);
                proveedor.setEmail(email);

                ProveedorDAO.insertProveedor(proveedor);

                response.sendRedirect("mostrarProveedores");
            } else {
                response.sendRedirect("error.jsp");
            }
        } catch (Exception e) {
            log.error("Error al crear el proveedor: " + e.getMessage());
            response.sendRedirect("error.jsp");
        }
    }

}
