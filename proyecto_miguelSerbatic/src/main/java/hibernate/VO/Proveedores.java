package hibernate.VO;

import javax.persistence.*;
import lombok.*;

@Entity
@Table(name = "proveedores", catalog = "tienda_miguel_serbatic")
@Data
@AllArgsConstructor
@NoArgsConstructor
public class Proveedores implements java.io.Serializable {

	@Id
	@GeneratedValue(strategy = GenerationType.IDENTITY)
	@Column(name = "id")
	private Integer id;

	@Column(name = "nombre", length = 255)
	private String nombre;

	@Column(name = "direccion", length = 255)
	private String direccion;

	@Column(name = "localidad", length = 255)
	private String localidad;

	@Column(name = "provincia", length = 255)
	private String provincia;

	@Column(name = "telefono", length = 255)
	private String telefono;

	@Column(name = "cif", length = 255)
	private String cif;

	@Column(name = "email", length = 255)
	private String email;
}
