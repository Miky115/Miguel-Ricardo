package org.apache.maven.geopaxil;

import java.awt.EventQueue;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;
import java.math.BigDecimal;
import java.net.URL;
import java.util.List;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import javax.swing.table.DefaultTableModel;

import org.apache.maven.BD.Comunidadesautonomas;
import org.apache.maven.BD.Provincias;
import org.apache.maven.BD.Pueblos;
import org.hibernate.Session;
import org.hibernate.exception.ConstraintViolationException;

import javax.swing.JMenuBar;
import javax.swing.JButton;
import javax.swing.JTable;
import javax.swing.JTextField;
import javax.swing.JLabel;
import java.awt.Font;
import javax.swing.ImageIcon;
import java.awt.Color;

public class ciudad extends JFrame {

	private static final long serialVersionUID = 1L;
	private JPanel contentPane;
	private JTable table;
	private JTextField textField;
	private JTextField textField_1;
	private JTextField textField_2;
	int selectedRow;
	private JTextField textField_3;
	private JTextField textField_4;
	private JTextField textField_5;

	private void añadir(DefaultTableModel model, Session s) {
		List<Provincias> listaProvincias = s.createQuery("FROM Provincias ORDER BY id DESC LIMIT 1", Provincias.class)
				.getResultList();
		for (Provincias provincia : listaProvincias) {
			model.addRow(new Object[] { provincia.getId(), provincia.getNombre(),
					provincia.getComunidadesautonomas().getId(), provincia.getCapital(), provincia.getPoblacion(),
					provincia.getSuperficieKm2() });
		}
	}

	private void rellenarTabla(DefaultTableModel model) {
		try (Session s = HibernateUtil.getSessionFactory().openSession()) {

			List<Provincias> listaProvincias = s.createQuery("FROM Provincias", Provincias.class).getResultList();

			for (Provincias provincia : listaProvincias) {
				model.addRow(new Object[] { provincia.getId(), provincia.getNombre(),
						provincia.getComunidadesautonomas().getId(), provincia.getCapital(), provincia.getPoblacion(),
						provincia.getSuperficieKm2() });
			}

		} catch (Exception e) {
			e.printStackTrace(System.err);
		}
	}

	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					ciudad frame = new ciudad();
					frame.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	public ciudad() {

		DefaultTableModel model = new DefaultTableModel();

		model.addColumn("Columna 1");
		model.addColumn("Columna 2");
		model.addColumn("Columna 3");
		model.addColumn("Columna 4");
		model.addColumn("Columna 5");
		model.addColumn("Columna 6");

		rellenarTabla(model);

		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 1109, 668);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));

		setContentPane(contentPane);
		contentPane.setLayout(null);

		JMenuBar menuBar = new JMenuBar();
		menuBar.setForeground(new Color(255, 255, 255));
		menuBar.setBackground(new Color(5, 141, 197));
		menuBar.setBounds(0, 0, 333, 29);
		contentPane.add(menuBar);

		JButton btnNewButton = new JButton("Añadir");
		btnNewButton.setForeground(new Color(255, 255, 255));
		btnNewButton.setBackground(new Color(5, 141, 197));
		btnNewButton.setBorderPainted(false);
		btnNewButton.setFont(new Font("Arial Black", Font.BOLD, 12));
		menuBar.add(btnNewButton);

		JButton btnNewButton_1 = new JButton("Modificar");
		btnNewButton_1.setForeground(new Color(255, 255, 255));
		btnNewButton_1.setBackground(new Color(5, 141, 197));
		btnNewButton_1.setBorderPainted(false);
		btnNewButton_1.setFont(new Font("Arial Black", Font.BOLD, 12));
		menuBar.add(btnNewButton_1);

		JButton btnNewButton_2 = new JButton("Eliminar");
		btnNewButton_2.setForeground(new Color(255, 255, 255));
		btnNewButton_2.setBackground(new Color(5, 141, 197));
		btnNewButton_2.setBorderPainted(false);
		btnNewButton_2.setFont(new Font("Arial Black", Font.BOLD, 12));
		menuBar.add(btnNewButton_2);

		JButton btnNewButton_3 = new JButton("Menu");
		btnNewButton_3.setForeground(new Color(255, 255, 255));
		btnNewButton_3.setBackground(new Color(5, 141, 197));
		btnNewButton_3.setBorderPainted(false);
		btnNewButton_3.setFont(new Font("Arial Black", Font.BOLD, 12));
		btnNewButton_3.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				menu menu = new menu();
				menu.setVisible(true);
				dispose();
			}
		});
		menuBar.add(btnNewButton_3);

		table = new JTable(model);

		table.setRowSelectionAllowed(false);

		table.addMouseListener(new MouseAdapter() {
			@Override
			public void mouseClicked(MouseEvent e) {
				selectedRow = table.rowAtPoint(e.getPoint());
				textField.setText(String.valueOf(table.getValueAt(selectedRow, 0)));
				textField_1.setText(String.valueOf(table.getValueAt(selectedRow, 1)));
				textField_2.setText(String.valueOf(table.getValueAt(selectedRow, 2)));
				textField_3.setText(String.valueOf(table.getValueAt(selectedRow, 3)));
				textField_4.setText(String.valueOf(table.getValueAt(selectedRow, 4)));
				textField_5.setText(String.valueOf(table.getValueAt(selectedRow, 5)));
			}
		});
		table.setBounds(20, 92, 511, 394);
		contentPane.add(table);

		JButton btnNewButton_4 = new JButton("Salir");
		btnNewButton_4.setForeground(new Color(255, 255, 255));
		btnNewButton_4.setBackground(new Color(5, 141, 197));
		btnNewButton_4.setBorderPainted(false);
		btnNewButton_4.setFont(new Font("Arial Black", Font.BOLD, 12));
		btnNewButton_4.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				dispose();
			}
		});
		btnNewButton_4.setBounds(967, 585, 116, 33);
		contentPane.add(btnNewButton_4);

		textField = new JTextField();
		textField.setColumns(10);
		textField.setBounds(727, 249, 211, 22);
		contentPane.add(textField);

		textField_1 = new JTextField();
		textField_1.setColumns(10);
		textField_1.setBounds(727, 292, 211, 22);
		contentPane.add(textField_1);

		textField_2 = new JTextField();
		textField_2.setColumns(10);
		textField_2.setBounds(727, 336, 211, 22);
		contentPane.add(textField_2);

		JButton btnNewButton_5 = new JButton("Añadir");
		btnNewButton_5.setForeground(new Color(255, 255, 255));
		btnNewButton_5.setBackground(new Color(5, 141, 197));
		btnNewButton_5.setBorderPainted(false);
		btnNewButton_5.setFont(new Font("Arial Black", Font.BOLD, 12));
		btnNewButton_5.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {

				try (Session s = HibernateUtil.getSessionFactory().openSession()) {

					s.getTransaction().begin();
					Provincias pro = new Provincias();
					Comunidadesautonomas ca = s.get(Comunidadesautonomas.class, textField_2.getText());
					pro.setNombre(textField_1.getText());
					pro.setCapital(textField_3.getText());
					pro.setComunidadesautonomas(ca);
					pro.setPoblacion(Integer.parseInt(textField_4.getText()));
					BigDecimal bigDecimal = new BigDecimal(textField_5.getText());
					pro.setSuperficieKm2(bigDecimal);
					s.persist(pro);
					s.getTransaction().commit();

					añadir(model, s);

					textField.setText("");
					textField_1.setText("");
					textField_2.setText("");
					textField_3.setText("");
					textField_4.setText("");
					textField_5.setText("");

				} catch (Exception ex) {
					System.err.println("--- Pila de Excepciones INICIO ---");
					System.err.println("[superior]" + e.getClass().toString());
					Throwable th = ex;
					int i = 1;
					while ((th != null) && !(th instanceof ConstraintViolationException)) {
						th = th.getCause();
						System.err.println("[-" + (i++) + "]" + th.getClass().toString());
					}
					System.err.println("--- Pila de Excepciones FIN ---");
					if (th instanceof ConstraintViolationException) {
						ConstraintViolationException cve = (ConstraintViolationException) th;
						System.err.println("------------------------");
						System.err.println("Excepción de Hibernate Tipo: " + cve.getClass().getName() + " : ["
								+ cve.getMessage() + "]");
						System.err.println("Sentencia SQL: " + cve.getSQL());
						System.err.println("Restricción violada: " + cve.getConstraintName());
						System.err.println("Error de la Excepción SQLException: ");
						System.err.println(cve.getSQLException().getMessage());
						System.err.println("------------------------");

					} else {
						ex.printStackTrace(System.err);
					}
				}
			}
		});
		btnNewButton_5.setBounds(957, 463, 108, 23);
		contentPane.add(btnNewButton_5);

		JButton btnNewButton_6 = new JButton("Modificar");
		btnNewButton_6.setForeground(new Color(255, 255, 255));
		btnNewButton_6.setBackground(new Color(5, 141, 197));
		btnNewButton_6.setBorderPainted(false);
		btnNewButton_6.setFont(new Font("Arial Black", Font.BOLD, 12));
		btnNewButton_6.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				try (Session s = HibernateUtil.getSessionFactory().openSession()) {
					s.getTransaction().begin();

					s.createQuery(
							"UPDATE Provincias SET nombre=:nombrepr, capital=:capitalpr, comunidadesautonomas.id=:comunidadidpr, poblacion=:poblacionpr, superficieKm2=:superficiepr WHERE id=:oldName")
							.setParameter("oldName", textField.getText())
							.setParameter("nombrepr", textField_1.getText())
							.setParameter("capitalpr", textField_3.getText())
							.setParameter("comunidadidpr", textField_2.getText())
							.setParameter("poblacionpr", textField_4.getText())
							.setParameter("superficiepr", textField_5.getText()).executeUpdate();
					s.getTransaction().commit();
					
					model.setRowCount(0);
					rellenarTabla(model);

					textField.setText("");
					textField_1.setText("");
					textField_2.setText("");
					textField_3.setText("");
					textField_4.setText("");
					textField_5.setText("");

				} catch (Exception e1) {
					e1.printStackTrace(System.err);
				}
			}
		});
		btnNewButton_6.setBounds(957, 463, 108, 23);
		contentPane.add(btnNewButton_6);

		JButton btnNewButton_7 = new JButton("Eliminar");
		btnNewButton_7.setForeground(new Color(255, 255, 255));
		btnNewButton_7.setBackground(new Color(5, 141, 197));
		btnNewButton_7.setBorderPainted(false);
		btnNewButton_7.setFont(new Font("Arial Black", Font.BOLD, 12));
		btnNewButton_7.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				try (Session s = HibernateUtil.getSessionFactory().openSession()) {

					s.getTransaction().begin();
					s.createQuery("DELETE Pueblos WHERE provincias.id=:nombre")
							.setParameter("nombre", textField.getText()).executeUpdate();
					s.createQuery("DELETE Provincias WHERE id=:nombre").setParameter("nombre", textField.getText())
							.executeUpdate();
					s.getTransaction().commit();

					model.setRowCount(0);
					rellenarTabla(model);

					textField.setText("");
					textField_1.setText("");
					textField_2.setText("");
					textField_3.setText("");
					textField_4.setText("");
					textField_5.setText("");

				} catch (Exception e1) {
					e1.printStackTrace(System.err);
				}
				((DefaultTableModel) table.getModel()).removeRow(selectedRow);
				textField.setText("");
				textField_1.setText("");
				textField_2.setText("");

			}
		});
		btnNewButton_7.setBounds(957, 463, 108, 23);
		contentPane.add(btnNewButton_7);

		textField_3 = new JTextField();
		textField_3.setColumns(10);
		textField_3.setBounds(727, 381, 211, 22);
		contentPane.add(textField_3);

		textField_4 = new JTextField();
		textField_4.setColumns(10);
		textField_4.setBounds(727, 424, 211, 22);
		contentPane.add(textField_4);

		textField_5 = new JTextField();
		textField_5.setColumns(10);
		textField_5.setBounds(727, 465, 211, 22);
		contentPane.add(textField_5);

		JLabel lblNewLabel = new JLabel("Ref. Provincia");
		lblNewLabel.setFont(new Font("Arial Black", Font.BOLD, 14));
		lblNewLabel.setBounds(576, 249, 141, 22);
		contentPane.add(lblNewLabel);

		JLabel lblNewLabel_1 = new JLabel("Nombre:");
		lblNewLabel_1.setFont(new Font("Arial Black", Font.BOLD, 14));
		lblNewLabel_1.setBounds(576, 292, 141, 22);
		contentPane.add(lblNewLabel_1);

		JLabel lblNewLabel_2 = new JLabel("Ref. comunidad:");
		lblNewLabel_2.setFont(new Font("Arial Black", Font.BOLD, 14));
		lblNewLabel_2.setBounds(576, 336, 141, 22);
		contentPane.add(lblNewLabel_2);

		JLabel lblNewLabel_3 = new JLabel("Capital:");
		lblNewLabel_3.setFont(new Font("Arial Black", Font.BOLD, 14));
		lblNewLabel_3.setBounds(576, 378, 141, 22);
		contentPane.add(lblNewLabel_3);

		JLabel lblNewLabel_4 = new JLabel("Nº de habitantes:");
		lblNewLabel_4.setFont(new Font("Arial Black", Font.BOLD, 14));
		lblNewLabel_4.setBounds(576, 421, 141, 22);
		contentPane.add(lblNewLabel_4);

		JLabel lblNewLabel_5 = new JLabel("Superficie (km2):");
		lblNewLabel_5.setFont(new Font("Arial Black", Font.BOLD, 14));
		lblNewLabel_5.setBounds(576, 463, 141, 23);
		contentPane.add(lblNewLabel_5);
		
		JLabel lblNewLabel_6 = new JLabel("");
		lblNewLabel_6.setIcon(new ImageIcon(ComAutonoma.class.getResource("/org/apache/maven/geopaxil/doodlepng2.png")));
		lblNewLabel_6.setBounds(40, 31, 1003, 598);
		contentPane.add(lblNewLabel_6);

		lblNewLabel.setVisible(false);
		lblNewLabel_1.setVisible(false);
		lblNewLabel_2.setVisible(false);
		lblNewLabel_3.setVisible(false);
		lblNewLabel_4.setVisible(false);
		lblNewLabel_5.setVisible(false);
		textField.setVisible(false);
		textField_1.setVisible(false);
		textField_2.setVisible(false);
		textField_3.setVisible(false);
		textField_4.setVisible(false);
		textField_5.setVisible(false);
		btnNewButton_5.setVisible(false);
		btnNewButton_6.setVisible(false);
		btnNewButton_7.setVisible(false);

		btnNewButton.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				table.setRowSelectionAllowed(false);
				btnNewButton_5.setVisible(true);
				btnNewButton_6.setVisible(false);
				btnNewButton_7.setVisible(false);
				lblNewLabel.setVisible(false);
				textField.setVisible(false);
				lblNewLabel_1.setVisible(true);
				lblNewLabel_2.setVisible(true);
				lblNewLabel_3.setVisible(true);
				lblNewLabel_4.setVisible(true);
				lblNewLabel_5.setVisible(true);
				textField_1.setVisible(true);
				textField_2.setVisible(true);
				textField_3.setVisible(true);
				textField_4.setVisible(true);
				textField_5.setVisible(true);
			}
		});
		btnNewButton_1.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				btnNewButton_5.setVisible(false);
				btnNewButton_6.setVisible(true);
				btnNewButton_7.setVisible(false);
				lblNewLabel.setVisible(true);
				lblNewLabel_1.setVisible(true);
				lblNewLabel_2.setVisible(true);
				lblNewLabel_3.setVisible(true);
				lblNewLabel_4.setVisible(true);
				lblNewLabel_5.setVisible(true);
				textField.setVisible(true);
				textField_1.setVisible(true);
				textField_2.setVisible(true);
				textField_3.setVisible(true);
				textField_4.setVisible(true);
				textField_5.setVisible(true);
			}

		});
		btnNewButton_2.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				btnNewButton_5.setVisible(false);
				btnNewButton_6.setVisible(false);
				btnNewButton_7.setVisible(true);
				textField.setVisible(true);
				lblNewLabel.setVisible(true);
				lblNewLabel_1.setVisible(false);
				lblNewLabel_2.setVisible(false);
				lblNewLabel_3.setVisible(false);
				lblNewLabel_4.setVisible(false);
				lblNewLabel_5.setVisible(false);
				textField_1.setVisible(false);
				textField_2.setVisible(false);
				textField_3.setVisible(false);
				textField_4.setVisible(false);
				textField_5.setVisible(false);
			}
		});

	}
}
