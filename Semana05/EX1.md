Conteúdos da stack podem ser acedidos em qualquer altura / Falso,  apenas os contiodos da heap 
A stack mantém as variáveis locais / Verdadeiro
Os conteúdos de um tipo de valor podem estar na heap / Verdadeiro
Os conteúdos de um tipo de valor estão sempre na heap / Falso, podem estar na stack tambem
Os conteúdos de um tipo de referência estão sempre na heap / Falso, ´so na heap
O garbage collector limpa memória tanto na stack como na heap / Falso, só no heap.
Podemos atribuir null a tipos de valor / Falso, pois valores com numeros null dá erro pois não aceitas nulo mas sim numeros exemplos(int, double e float).
Tendo dois tipos de referência a e b a apontar para o mesmo objeto, modificar os conteúdos de a vai também alterar os conteúdos de b / Verdadeiro, pois está conectado com o heap.
Tendo dois tipos de valor a e b com o mesmo valor, modificar a vai também alterar b / Falso,  pois são tipos de valor e o heap não funciona em tipos de valores.
