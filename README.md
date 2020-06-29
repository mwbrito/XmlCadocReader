# XmlCadocReader
Project to help read the Bacen XML file Cadoc 3040.

## Visão geral do projeto
O projeto visa ler o arquivo xml do CADOC3040, carregando os dados do arquivo em classes C#. Dentro da pasta do projeto temos o arquivo SCR3040_Leiaute.xls com o layout do CADOC3040 utilizado.

A solução foi desenvolvida no MS Visual Studio 2017, utilizando C#.NET e testes com xUnit.

## Como utilizar
1. Adicione a referencia ao seu projeto;
2. Chame o metodo estatico **ReadCadoc3040File** da classe **ReadCadocs** passando a URL do arquivo xml como parâmetro, o retorno será um obejto **Cadoc3040File** com todos os dados do arquivo. Exemplo:
```
Cadoc3040File arquivo = ReadCadocs.ReadCadoc3040File(CadocUrl);
```

**Unit Tests are the Best Documentation**

## Como contribuir
O projeto está bem básico, a melhor contribuição para o projeto no momento é me solicitar a inclusão de mais funcionalidades, CADOCs, etc.

## Licença
Fique a vontade para incluir o projeto em sua solução e utilizá-lo sem restrições.
