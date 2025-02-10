package hilos;

import javax.servlet.ServletContextEvent;
import javax.servlet.ServletContextListener;
import javax.servlet.annotation.WebListener;

import service.PedidoServicio;

@WebListener
public class ActualizarPedidos implements ServletContextListener {

    private Thread updateThread;

    @Override
    public void contextInitialized(ServletContextEvent servletContextEvent) {
        updateThread = new Thread(new Runnable() {
			@Override
			public void run() {
			    while (true) {
			        try {
			            Thread.sleep(180000);
			            PedidoServicio.enviarPedidosPendientesHilo();
			            System.out.println("Enviados los pedidos");
			        } catch (InterruptedException e) {
			            Thread.currentThread().interrupt();
			            break;
			        }
			    }
			}
		});
        updateThread.start();
    }

    @Override
    public void contextDestroyed(ServletContextEvent servletContextEvent) {
        updateThread.interrupt();
    }
}
