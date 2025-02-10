package control.usuario;

import java.io.IOException;
import java.util.ArrayList;
import java.util.List;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import model.DAO.PedidoDAO;
import model.DAO.ProductoDAO;
import model.DAO.ValoracionDAO;
import model.VO.MostrarValoracionVO;
import model.VO.PedidoVO;
import model.VO.ProductoVO;
import model.VO.UsuarioVO;
import model.VO.ValoracionVO;
import service.UsuarioServicio;

@WebServlet("/inicioAdmin")
public class InicioAdminServlet extends HttpServlet {
    private static final long serialVersionUID = 1L;

    public InicioAdminServlet() {
        super();
    }

    protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {

        ArrayList<PedidoVO> ultimosPedidos = PedidoDAO.getUltimosPedidosPorDia(5);
        ArrayList<PedidoVO> pedidos = PedidoDAO.getPedidos();
        List<ProductoVO> productos = ProductoDAO.getProductos();
        List<UsuarioVO> usuarios = UsuarioServicio.verClientes();
        List<MostrarValoracionVO> valoraciones = ValoracionDAO.getValoraciones();

        request.setAttribute("ultimosPedidos", ultimosPedidos);
        request.setAttribute("numPedidos", pedidos.size());
        request.setAttribute("numProductos", productos.size());
        request.setAttribute("numUsuarios", usuarios.size());
        request.setAttribute("valoraciones", valoraciones);

        request.getRequestDispatcher("inicioAdmin.jsp").forward(request, response);
    }

    protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
        doGet(request, response);
    }
}
