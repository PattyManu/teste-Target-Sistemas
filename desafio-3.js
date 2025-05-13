//3) Dado um vetor que guarda o valor de faturamento diário de uma distribuidora, faça um programa, na linguagem que desejar, que calcule e retorne:
//• O menor valor de faturamento ocorrido em um dia do mês;
//• O maior valor de faturamento ocorrido em um dia do mês;
//• Número de dias no mês em que o valor de faturamento diário foi superior à média mensal.

const fs = require('fs');

const dados = JSON.parse(fs.readFileSync('faturamento.json', 'utf8'));

const faturamentosValidos = dados
  .filter(dia => dia.valor > 0)
  .map(dia => dia.valor);

const menor = Math.min(...faturamentosValidos);
const maior = Math.max(...faturamentosValidos);

const soma = faturamentosValidos.reduce((total, valor) => total + valor, 0);
const media = soma / faturamentosValidos.length;

const diasAcimaDaMedia = faturamentosValidos.filter(valor => valor > media).length;

console.log("Menor faturamento em um dia do mês:", menor.toFixed(2));
console.log("Maior faturamento em um dia do mês:", maior.toFixed(2));
console.log("Número de dias com faturamento acima da média:", diasAcimaDaMedia);
