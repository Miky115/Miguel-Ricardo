package org.apache.maven.geopaxil;

import org.hibernate.SessionFactory;
import org.hibernate.cfg.Configuration;

public class HibernateUtil {
	private static final SessionFactory sessionFactory;
	
	static {
		try {
			//Creación de la Sessión
			sessionFactory = new Configuration().configure().buildSessionFactory();
			
		} catch(Throwable ex) {
			System.err.println("Error al Inicializar la sesión: "+ex);
			throw new ExceptionInInitializerError(ex);
		}
	}
	
	public static SessionFactory getSessionFactory() {
		return sessionFactory;
	}
}
