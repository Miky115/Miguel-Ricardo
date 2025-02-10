package hibernate.VO;

import javax.persistence.*;

import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;

@Entity
@Table(name = "configuracion", catalog = "tienda_miguel_serbatic")
@Data
@AllArgsConstructor
@NoArgsConstructor
public class Configuracion implements java.io.Serializable {

	@Id
	@GeneratedValue(strategy = GenerationType.IDENTITY)
	@Column(name = "id")
	private Integer id;

	@Column(name = "clave", length = 255)
	private String clave;

	@Column(name = "valor", length = 255)
	private String valor;

	@Column(name = "tipo", length = 255)
	private String tipo;
}
