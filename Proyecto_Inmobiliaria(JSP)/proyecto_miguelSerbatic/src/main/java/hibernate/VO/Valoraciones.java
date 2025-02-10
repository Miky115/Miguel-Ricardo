package hibernate.VO;

import lombok.*;

import javax.persistence.*;

@Entity
@Table(name = "valoraciones", catalog = "tienda_miguel_serbatic")
@Data
@AllArgsConstructor
@NoArgsConstructor
public class Valoraciones implements java.io.Serializable {

	@Id
	@GeneratedValue(strategy = GenerationType.IDENTITY)
	@Column(name = "id")
	private Integer id;

	@ManyToOne(fetch = FetchType.LAZY)
	@JoinColumn(name = "id_producto")
	private Productos productos;

	@ManyToOne(fetch = FetchType.LAZY)
	@JoinColumn(name = "id_usuario")
	private Usuarios usuarios;

	@Column(name = "valoracion")
	private Integer valoracion;

	@Column(name = "comentario", length = 255)
	private String comentario;
}
