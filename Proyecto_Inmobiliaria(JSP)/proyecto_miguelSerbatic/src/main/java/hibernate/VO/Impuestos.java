package hibernate.VO;

import javax.persistence.*;
import lombok.*;

@Entity
@Table(name = "impuestos", catalog = "tienda_miguel_serbatic")
@Data
@AllArgsConstructor
@NoArgsConstructor
public class Impuestos implements java.io.Serializable {

    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Column(name = "id")
    private Integer id;

    @Column(name = "impuesto")
    private Float impuesto;
}
