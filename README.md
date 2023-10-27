# TechnicalTest2023
NEXER-BRA Technical Test 2023

## Processo Seletivo Nexer - Marcelo Takayama

Exercício C#

### 3.1 AJUSTAR PROBLEMA AO CADASTRAR CAMINHÃO
Ao adicionar um novo veículo do tipo Caminhão, o sistema cadastra de forma errada um
novo veículo do tipo Carro. Ajuste para que ao adicionar um novo veículo, o sistema faça
o registro correto do tipo informado pelo usuário.

Solução

Commit com a solução deste problema: https://github.com/marcelotakayama/TechnicalTest2023/commit/cdb2f7c76ee9ea2318f03b78d71bf6d869a56dfa 

Para a resolução deste problema, primeiro fiz uma análise do código já existente no programa, rodando o programa e realizando alguns testes, e ao perceber que o problema estava na hora de cadastrar um novo veículo do tipo “Caminhão” percebi que o erro estava no arquivo Data.cs, pois nele, a caixa de texto mostrava o dado como “Caminhão”, porém ao passar na lógica de cadastro ele não funcionava pois ele reconhece apenas o tipo “Caminhao” sem acento, por isso retirei o acento do Data.cs e assim fui capaz de cadastrar um caminhão no sistema

### 3.2 IMPLEMENTAR NOVO TRANSPORTE AVIÃO
A empresa busca expandir sua área de atuação e pretende adquirir alguns aviões.
Implemente a possibilidade de cadastrar o tipo Avião na frota dentro do sistema.
Resultado esperado:
Deverá ser possível cadastrar o novo tipo Avião dentro da tela Adicionar Veículo e
visualizá-los na tela Veículos Cadastrados.

Solução

Commit com a solução deste problema: https://github.com/marcelotakayama/TechnicalTest2023/commit/cdb2f7c76ee9ea2318f03b78d71bf6d869a56dfa 

Para a resolução deste problema, criei uma nova classe representando um avião e adicionei os campos de avião onde necessário, como em Data.cs e Factory.cs. Assim consegui ser capaz de realizar o cadastro de um veículo do tipo avião

### 3.3 IMPLEMENTAR CADASTRO DE COMBUSTÍVEL NOS VEÍCULOS
Implemente o campo Combustível no cadastro Adicionar Veículos, cada veículo da companhia tem apenas 1 tipo de combustível.
O campo Combustível será uma lista pré-definida de valores, como na tela Tabela de
Combustível.

Solução

Commit com a solução deste problema: https://github.com/marcelotakayama/TechnicalTest2023/commit/24a9d12ab517087d1b35bf8c1948d3740d7ea7bf 

Para a resolução deste problema, precisei fazer alguns ajustes no código, como:

* Criar o campo de input de combustível no designer de AddVehicle
* Adicionar o campo combustível no designer de ViewVehicle
* Ajustar os campos necessários para suportarem o novo tipo combustível


### 3.4 IMPLEMENTAR FUNÇÃO PARA CÁLCULO DE FRETE
Implemente uma nova função na tela Cálculo de Frete que exiba o veículo ideal para o
frete e o custo do frete para a entrega.

Solução:

Commit com a solução deste problema: 
https://github.com/marcelotakayama/TechnicalTest2023/commit/2b5997a7d3711a730548596cb733d2f3f90572d7 

Para este problema, precisei realizar o cálculo de frete, e criar uma caixa de texto com o output do cálculo:

                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    
 

