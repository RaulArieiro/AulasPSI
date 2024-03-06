
# Pesquisa sobre Bases de Dados


Sistema de Gerenciamento de Banco de Dados Relacional (SGBDR)
Modelo Relacional:Apresenta uma organização de dados em tabelas com linhas e colunas e assim fica facil e claro para comprieder as relações entre entidades.

Linguagem SQL(Structured Query Language):Permite realizar consultas, inserir, modificar, atualizar, excluir e definir e modificar a estrutura das tabelas.

Integridade Relacional:Os SGBDR garantem a integridade referencial, garantindo que relações entre tabelas sejam validas e que as chaves estrangeiras indiquem para registos ja existentes.

Chave Primária: Cada tabela normalmente possui uma chave primária única que identifica de maneira exclusiva cada registro na tabela.
Chave Estrangeira: Permite a criação de relações entre tabelas, referenciando a chave primária de uma tabela em outra, estabelecendo assim integridade referencial.

Transações: Comporta o conseito de transações permitindo que faça varios tipos de operações sejam executados como uma unidade atômica, garantindo que aja consistência e integridade dos dados.
Normalização: Processo de organização de dados para reduzir redundâncias e melhorar a eficiência, permanecendo com as formas normais para manter a estrutura mais eficiência e longe de anomalias.

Concorrência e Controle de Acesso: Gére o acesso concorrente de vários usuários ao banco de dados, garantindo consistência e isolamento por meio de mecanismos de controle de concorrência e controle de acesso.
Recuperação de Falhas: Implementa mecanismos para recuperar dados após falhas do sistema, como algumas transações não concluidas por alguns erros.

Segurança: Oferece recursos de segurança, como controle de acesso baseado em permissões, para garantir que apenas usuários autorizados tenham acesso aos dados.
Backup e Recuperação: Possui recursos para realizar cópias de segurança periódicas (backup) e restaurar dados em caso de perda ou corrupção.

Os sistemas NoSQL costumam usar as propria linguagem como; MongoDB (Banco de Dados de Documentos):Linguagem MongoDB Query Language (MQL) para consultas, Cassandra (Banco de Dados de Colunas):Linguagem CQL (Cassandra Query Language) para consultas e Amazon DynamoDB (Banco de Dados Chave-Valor e de Documentos): DynamoDB utiliza operações específicas para realizar consultas e manipulações. 

Modelo de Dados Variado: Diferentemente dos SGBDR, os bancos de dados NoSQL suportam diversos modelos de dados, como documentos, chave-valor, colunas e grafos. Cada modelo é projetado para atender a diferentes tipos de dados e casos de uso.

Estrutura Flexível: Os bancos de dados NoSQL são conhecidos por sua flexibilidade em relação à estrutura dos dados. Eles podem lidar com esquemas dinâmicos, permitindo adicionar campos aos documentos sem necessariamente de uma estrutura de tabela inflexível. 

Escalabilidade Horizontal: Muitos bancos de dados NoSQL são projetados para escalar horizontalmente, que significa que podem lidar com grandes quantidades de dados os distribuindo - os em vairos servidores.
Alta Performance em Leitura e Gravação: Em muitos casos, os bancos de dados NoSQL são otimizados para operações de leitura e gravação em grande escala, proporcionando alta performance para ambas as operações.

Sem Suporte para Transações ACID Completo: Enquanto os SGBDR seguem o modelo ACID (Atomicidade, Consistência, Isolamento, Durabilidade), muitos bancos de dados NoSQL oferecem suporte a um subconjunto de propriedades ACID ou adotam um modelo diferente, como o BASE (Basically Available, Soft state, Eventually consistent).

Uma das principais vantegens do NoSQL é a sua capacidade de lidar com grandes quantidades de dados, agora o SGBDR é mais consetrado em manter a segurança entre transações, ter uma linguagem padrão então só é necessario aprender - la manter as informações atualizada imediatemente a apos a sua alteração. Desvantagens ele por ser complexo se ter muitas informações sera dificil encontrar os dados que desejar. O NoSQL consegue mesmo com grandes volumes de dados ter uma grande flexibilidade, por ser flexivel tambem é facil de desenvolver por não ter um padrão nunca se sabe como ter de trabalhar ou até ter de aprender a linguagem e não é muito eficiente para casos que são complexos e rigorosos.