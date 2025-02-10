package hibernate.VO;

import java.util.HashSet;
import java.util.Set;
import javax.persistence.*;

import lombok.*;

@Entity
@Table(name = "roles", catalog = "tienda_miguel_serbatic")
@Data
@AllArgsConstructor
@NoArgsConstructor
public class Roles implements java.io.Serializable {

	@Id
	@GeneratedValue(strategy = GenerationType.IDENTITY)
	@Column(name = "id")
	private Integer id;

	@Column(name = "rol", length = 255)
	private String rol;

	@OneToMany(fetch = FetchType.LAZY, mappedBy = "roles")
	private Set<OpcionesMenu> opcionesMenus = new HashSet<>(0);

	@OneToMany(fetch = FetchType.LAZY, mappedBy = "roles")
	private Set<Usuarios> usuarioses = new HashSet<>(0);
}
