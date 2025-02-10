package hibernate.VO;

import javax.persistence.*;
import lombok.*;

@Entity
@Table(name = "metodos_pago", catalog = "tienda_miguel_serbatic")
@Data
@AllArgsConstructor
@NoArgsConstructor
public class MetodosPago implements java.io.Serializable {

    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Column(name = "id")
    private Integer id;

    @Column(name = "metodo_pago", length = 255)
    private String metodoPago;
}
