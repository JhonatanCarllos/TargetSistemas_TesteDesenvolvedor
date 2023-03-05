print(f"Converso de texto\n")
while(True):
    escolha = int(input("Qual opção deseja\n1 - Converso\n0 - exit\n"))
    if( escolha == 1):
        texto = input(f"Insira a palavra a ser convertida: ")
        print(f"\nA palavra convertido será = {texto[::-1]}\n")#usei a função slice pois facilita o código e otimiza para um pedido simples
    else:
        break