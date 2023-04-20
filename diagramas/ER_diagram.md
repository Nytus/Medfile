```mermaid
erDiagram

    USUARIO |o..|| ESPECIALIDAD : Tiene
    ROL ||--|| USUARIO : ASD
    NACIONALIDAD ||--|| USUARIO : ASD
    FICHA_MEDICA ||--|{ USUARIO: ASD
    USUARIO ||--|| USUARIO_CITA: ASD
    USUARIO_CITA ||--|| CLINICA : ASD
    CITA_MEDICA ||--|| TIPO_CITA: ASD
    CITA_MEDICA ||--|| USUARIO_CITA: ASD
    FICHA_MEDICA ||--|{ CITA_MEDICA: ASD
    IMAGEN ||..|{ CITA_MEDICA: ASD
    RECETA ||..|| CITA_MEDICA: ASD
    RECETA ||--|| RECETA_MEDICAMENTO : ASD
    RECETA_MEDICAMENTO ||--|| MEDICAMENTO: ASD

    IMAGEN {
        int id_imagen
        str nombre
        str direccion
    }
    
    RECETA_MEDICAMENTO {
        int id_receta
        int id_medicamento
    }

    CITA_MEDICA {
        int id_cita PK
        date fecha
    }    
    
    FICHA_MEDICA {
        int id_ficha
        str nombre
        str rut
        date fecha_inicio
    }
    
    CLINICA {
        int id_clinica
        str nombre
        str region
        str direccion
    }

    USUARIO {
        int id_usuario PK
        str nombre
        str apellido_p
        str apellido_m
        str email UK
        str telefono UK
    }

    ROL {
        int id_rol PK
        str rol UK
    }

    ESPECIALIDAD {
        int id_especialidad PK
        str especialidad UK
    }

    NACIONALIDAD {
        int id_nacionalidad
        str nacionalidad
    }

    USUARIO_CITA {
        int id_usuario PK, FK
        int id_consulta PK, FK
        int id_clinica PK,FK
        str estado
    }

    TIPO_CITA {
        int id_tipo
        str tipo_cita
    }

    RECETA {
        int id_receta PK
        date fecha
        int id_consulta FK
    }

    MEDICAMENTO {
        int id_medicamento PK
        str nombre
        str formula
        str concentracion
    }