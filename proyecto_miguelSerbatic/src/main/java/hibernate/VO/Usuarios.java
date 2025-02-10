package hibernate.VO;

import java.util.HashSet;
import java.util.Set;
import javax.persistence.*;

import lombok.*;

@Entity
@Table(name = "usuarios", catalog = "tienda_miguel_serbatic")
@Data
@AllArgsConstructor
@NoArgsConstructor
public class Usuarios implements java.io.Serializable {

	@Id
	@GeneratedValue(strategy = GenerationType.IDENTITY)
	@Column(name = "id")
	private Integer id;

	@ManyToOne(fetch = FetchType.LAZY)
	@JoinColumn(name = "id_rol")
	private Roles roles;

	@Column(name = "email", length = 255)
	private String email;

	@Column(name = "clave", length = 255)
	private String clave;

	@Column(name = "nombre", length = 255)
	private String nombre;

	@Column(name = "apellido1", length = 255)
	private String apellido1;

	@Column(name = "apellido2", length = 255)
	private String apellido2;

	@Column(name = "direccion", length = 255)
	private String direccion;

	@Column(name = "provincia", length = 255)
	private String provincia;

	@Column(name = "localidad", length = 255)
	private String localidad;

	@Column(name = "telefono", length = 255)
	private String telefono;

	@Column(name = "dni", length = 255)
	private String dni;

	@OneToMany(fetch = FetchType.LAZY, mappedBy = "usuarios")
	private Set<Valoraciones> valoracioneses = new HashSet<>(0);

	@OneToMany(fetch = FetchType.LAZY, mappedBy = "usuarios")
	private Set<Pedidos> pedidoses = new HashSet<>(0);
}
