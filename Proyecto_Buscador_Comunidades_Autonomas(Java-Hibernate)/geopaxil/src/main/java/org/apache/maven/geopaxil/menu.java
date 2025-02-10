package org.apache.maven.geopaxil;

import java.awt.BorderLayout;
import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.JTable;
import javax.swing.JTextField;
import javax.swing.border.EmptyBorder;
import javax.swing.JLabel;
import javax.swing.SwingConstants;
import java.awt.Font;
import javax.swing.JButton;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;
import java.awt.SystemColor;
import java.awt.Color;
import javax.swing.ImageIcon;

public class menu extends JFrame {

	private static final long serialVersionUID = 1L;
	private JPanel contentPane;

	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					menu frame = new menu();
					frame.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	public menu() {
		setTitle("Geopaxil");
		
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 842, 434);
		contentPane = new JPanel();
		contentPane.setBackground(new Color(255, 255, 255));
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));

		setContentPane(contentPane);
		contentPane.setLayout(null);
		
		JLabel lblNewLabel_2 = new JLabel("Creado por: David Pajares Pardal y Miguel Ricardo Silvestre Bernardino");
		lblNewLabel_2.setForeground(new Color(255, 255, 255));
		lblNewLabel_2.setFont(new Font("Arial Black", Font.PLAIN, 12));
		lblNewLabel_2.setBackground(new Color(170, 21, 27));
		lblNewLabel_2.setOpaque(true);
		lblNewLabel_2.setBounds(0, 364, 474, 31);
		contentPane.add(lblNewLabel_2);
		
		JLabel lblNewLabel = new JLabel("MENÚ");
		lblNewLabel.setForeground(new Color(255, 255, 255));
		lblNewLabel.setFont(new Font("Tahoma", Font.PLAIN, 48));
		lblNewLabel.setHorizontalAlignment(SwingConstants.CENTER);
		lblNewLabel.setBounds(241, 11, 364, 83);
		contentPane.add(lblNewLabel);
		
		JButton btnNewButton = new JButton("Comunidad autónoma");
		btnNewButton.setForeground(new Color(255, 255, 255));
		btnNewButton.setIcon(null);
		btnNewButton.setBackground(new Color(170, 21, 29));
		btnNewButton.setBorderPainted(false);
		btnNewButton.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				ComAutonoma comauto = new ComAutonoma();
                comauto.setVisible(true);
                dispose();
			}
		});
		btnNewButton.setFont(new Font("Tahoma", Font.PLAIN, 20));
		btnNewButton.setBounds(20, 194, 234, 94);
		contentPane.add(btnNewButton);
		
		JButton btnCiudad = new JButton("Ciudades");
		btnCiudad.setForeground(new Color(255, 255, 255));
		btnCiudad.setBackground(new Color(170, 21, 29));
		btnCiudad.setBorderPainted(false);
		btnCiudad.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				ciudad ciudad = new ciudad();
                ciudad.setVisible(true);
                dispose();
                
			}
		});
		btnCiudad.setFont(new Font("Tahoma", Font.PLAIN, 20));
		btnCiudad.setBounds(299, 194, 234, 94);
		contentPane.add(btnCiudad);
		
		JButton btnNewButton_1_1 = new JButton("Pueblos");
		btnNewButton_1_1.setForeground(new Color(255, 255, 255));
		btnNewButton_1_1.setBackground(new Color(170, 21, 29));
		btnNewButton_1_1.setBorderPainted(false);
		btnNewButton_1_1.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				pueblos pueblos = new pueblos();
                pueblos.setVisible(true);
                dispose();
			}
		});
		btnNewButton_1_1.setFont(new Font("Tahoma", Font.PLAIN, 20));
		btnNewButton_1_1.setBounds(571, 194, 234, 94);
		contentPane.add(btnNewButton_1_1);
		
		JLabel lblNewLabel_1 = new JLabel("");
		lblNewLabel_1.setIcon(new ImageIcon(menu.class.getResource("/org/apache/maven/geopaxil/maxresdefault.jpg")));
		lblNewLabel_1.setBounds(0, 0, 826, 395);
		contentPane.add(lblNewLabel_1);
	}
}
