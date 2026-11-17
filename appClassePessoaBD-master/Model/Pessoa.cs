/*
 * A biblioteca SQLite é chamada aqui para que as anotações de chave primária
 * e de autoIncremento possam ser usadas na propriedade pesID
 */
using SQLite;

namespace appClassePessoaBD.Model
{
    // Define que esta entidade será mapeada para a tabela "Pessoa" no banco de dados
    [Table("Pessoa")]
    public class Pessoa
    {
        // Define que este campo é a chave primária da tabela
        // Configura o valor para ser incrementado automaticamente pelo banco de dados
        // Garante que o valor seja único para cada registro
        // Impede que o campo receba valores nulos
        [PrimaryKey, AutoIncrement, Unique, NotNull]

        // Declara a propriedade pesID do tipo inteiro
        // Representa o identificador único da pessoa
        public int pesID { get; set; }
        // Define que o valor armazenado nesta propriedade pode ter no máximo 1000 caracteres
        [MaxLength(1000)]
        // Declara a propriedade pesNome do tipo string
        // O símbolo '?' indica que a propriedade pode receber valor nulo
        // Armazena o nome da pessoa
        public string? pesNome { get; set; }
        // Define que o valor armazenado nesta propriedade pode
        // ter no máximo 3 caracteres/dígitos
        [MaxLength(3)]
        // Declara a propriedade pesIdade do tipo inteiro (int)
        // Armazena a idade da pessoa
        public int pesIdade { get; set; }
    }
}
