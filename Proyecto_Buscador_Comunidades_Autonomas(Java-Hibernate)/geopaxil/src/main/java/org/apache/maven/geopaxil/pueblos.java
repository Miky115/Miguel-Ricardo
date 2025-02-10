package org.apache.maven.geopaxil;

import java.awt.EventQueue;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;
import java.util.List;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import javax.swing.table.DefaultTableModel;
import javax.swing.table.TableColumn;
import javax.swing.table.TableColumnModel;

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

public class pueblos extends JFrame {

	private static final long serialVersionUID = 1L;
	private JPanel contentPane;
	private JTable table;
	private JLabel lblNewLabel;
	private JLabel lblNewLabel_1;
	private JLabel lblNewLabel_2;
	private JLabel lblNewLabel_3;
	private JLabel lblNewLabel_4;
	private JLabel lblNewLabel_5;

	private JTextField textField;
	private JTextField textField_1;
	private JTextField textField_2;
	int selectedRow;
	private JTextField textField_3;
	private JTextField textField_4;
	private JTextField textField_5;
	private JLabel lblNewLabel_6;

	private void añadir(DefaultTableModel model, Session s) {
		List<Pueblos> listaPueblos = s.createQuery("FROM Pueblos ORDER BY id DESC LIMIT 1", Pueblos.class)
				.getResultList();

		for (Pueblos pueblo1 : listaPueblos) {
			model.addRow(new Object[] { pueblo1.getId(), pueblo1.getNombre(), pueblo1.getProvincias().getId(),
					pueblo1.getPoblacion(), pueblo1.getCodigoPostal(), pueblo1.getCoordenadasGeograficas() });
		}
	}

	private void rellenarTabla(DefaultTableModel model) {
		try (Session s = HibernateUtil.getSessionFactory().openSession()) {
			List<Pueblos> listaPueblos = s.createQuery("FROM Pueblos", Pueblos.class)
					.getResultList();

			for (Pueblos pueblo1 : listaPueblos) {
				model.addRow(new Object[] { pueblo1.getId(), pueblo1.getNombre(), pueblo1.getProvincias().getId(),
						pueblo1.getPoblacion(), pueblo1.getCodigoPostal(), pueblo1.getCoordenadasGeograficas() });
			}
		} catch (Exception e) {
			e.printStackTrace(System.err);
		}
	}

	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					pueblos frame = new pueblos();
					frame.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	public pueblos() {

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

		TableColumnModel columnModel = table.getColumnModel();

		TableColumn column = columnModel.getColumn(0);
		column.setPreferredWidth(1);
		column = columnModel.getColumn(1);
		column.setPreferredWidth(110);
		column = columnModel.getColumn(2);
		column.setPreferredWidth(5);
		column = columnModel.getColumn(3);
		column.setPreferredWidth(30);
		column = columnModel.getColumn(4);
		column.setPreferredWidth(20);
		column = columnModel.getColumn(5);
		column.setPreferredWidth(130);
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
		textField.setBounds(736, 246, 211, 22);
		contentPane.add(textField);

		textField_1 = new JTextField();
		textField_1.setColumns(10);
		textField_1.setBounds(736, 289, 211, 22);
		contentPane.add(textField_1);

		textField_2 = new JTextField();
		textField_2.setColumns(10);
		textField_2.setBounds(736, 332, 211, 22);
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
					Provincias pro = s.get(Provincias.class, textField_4.getText());
					Pueblos pueblo = new Pueblos();
					pueblo.setNombre(textField_1.getText());
					pueblo.setProvincias(pro);
					pueblo.setPoblacion(Integer.parseInt(textField_2.getText()));
					pueblo.setCodigoPostal(textField_3.getText());
					pueblo.setCoordenadasGeograficas(textField_5.getText());
					s.persist(pueblo);
					s.getTransaction().commit();

					textField.setText("");
					textField_1.setText("");
					textField_2.setText("");
					textField_3.setText("");
					textField_4.setText("");
					textField_5.setText("");

					añadir(model, s);
				} catch (Exception e1) {
					System.err.println("--- Pila de Excepciones INICIO ---");
					System.err.println("[superior]" + e1.getClass().toString());
					Throwable th = e1;
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
						e1.printStackTrace(System.err);
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
		btnNewButton_6.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				try (Session s = HibernateUtil.getSessionFactory().openSession()) {
					s.getTransaction().begin();

					s.createQuery(
							"UPDATE Pueblos SET nombre=:nombrepu, provincias.id=:provincia, poblacion=:poblacionpu, codigoPostal=:codigoPostalpu, coordenadasGeograficas=:coordenadasGeograficas WHERE id=:oldName")
							.setParameter("oldName", textField.getText())
							.setParameter("nombrepu", textField_1.getText())
							.setParameter("provincia", textField_2.getText())
							.setParameter("poblacionpu", textField_3.getText())
							.setParameter("codigoPostalpu", textField_4.getText())
							.setParameter("coordenadasGeograficas", textField_5.getText()).executeUpdate();
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
		btnNewButton_7.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				try (Session s = HibernateUtil.getSessionFactory().openSession()) {
					s.getTransaction().begin();
					s.createQuery("DELETE FROM Pueblos WHERE id=:nombre")
							.setParameter("nombre", Integer.parseInt(textField.getText())).executeUpdate();
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
		btnNewButton_7.setBounds(957, 463, 108, 23);
		contentPane.add(btnNewButton_7);

		textField_3 = new JTextField();
		textField_3.setColumns(10);
		textField_3.setBounds(736, 377, 211, 22);
		contentPane.add(textField_3);

		textField_4 = new JTextField();
		textField_4.setColumns(10);
		textField_4.setBounds(736, 421, 211, 22);
		contentPane.add(textField_4);

		textField_5 = new JTextField();
		textField_5.setColumns(10);
		textField_5.setBounds(736, 464, 211, 22);
		contentPane.add(textField_5);

		lblNewLabel = new JLabel("Ref. pueblo");
		lblNewLabel.setFont(new Font("Arial Black", Font.BOLD, 14));
		lblNewLabel.setBounds(606, 246, 118, 18);
		contentPane.add(lblNewLabel);

		lblNewLabel_1 = new JLabel("Nombre:");
		lblNewLabel_1.setFont(new Font("Arial Black", Font.BOLD, 14));
		lblNewLabel_1.setBounds(606, 289, 118, 18);
		contentPane.add(lblNewLabel_1);

		lblNewLabel_2 = new JLabel("Ref. provincia:");
		lblNewLabel_2.setFont(new Font("Arial Black", Font.BOLD, 14));
		lblNewLabel_2.setBounds(606, 331, 118, 18);
		contentPane.add(lblNewLabel_2);

		lblNewLabel_3 = new JLabel("Poblacion:");
		lblNewLabel_3.setFont(new Font("Arial Black", Font.BOLD, 14));
		lblNewLabel_3.setBounds(606, 376, 118, 18);
		contentPane.add(lblNewLabel_3);

		lblNewLabel_4 = new JLabel("Codigo postal:");
		lblNewLabel_4.setFont(new Font("Arial Black", Font.BOLD, 14));
		lblNewLabel_4.setBounds(606, 420, 118, 18);
		contentPane.add(lblNewLabel_4);

		lblNewLabel_5 = new JLabel("Coordenadas:");
		lblNewLabel_5.setFont(new Font("Arial Black", Font.BOLD, 14));
		lblNewLabel_5.setBounds(606, 464, 118, 13);
		contentPane.add(lblNewLabel_5);
		
		lblNewLabel_6 = new JLabel("");
		lblNewLabel_6.setIcon(new ImageIcon(pueblos.class.getResource("/org/apache/maven/geopaxil/doodlepng2.png")));
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
