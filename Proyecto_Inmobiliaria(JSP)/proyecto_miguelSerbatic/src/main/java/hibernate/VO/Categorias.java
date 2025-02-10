package hibernate.VO;
// Generated 20 abr 2024 15:51:52 by Hibernate Tools 6.3.1.Final

import java.util.HashSet;
import java.util.Set;

import javax.persistence.*;

import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;

@Entity
@Table(name = "categorias", catalog = "tienda_miguel_serbatic")
@Data
@AllArgsConstructor
@NoArgsConstructor
public class Categorias implements java.io.Serializable {

	@Id
	@GeneratedValue(strategy = GenerationType.IDENTITY)
	@Column(name = "id")
	private Integer id;

	@Column(name = "nombre", length = 255)
	private String nombre;

	@Column(name = "descripcion", length = 255)
	private String descripcion;

	@OneToMany(fetch = FetchType.LAZY, mappedBy = "categorias")
	private Set<Productos> productos = new HashSet<>(0);

}
