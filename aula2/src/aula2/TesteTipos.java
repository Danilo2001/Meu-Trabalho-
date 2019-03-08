package aula2;

import javax.swing.JOptionPane;

public class TesteTipos {

	public static void main(String[] args) {
		// CamelCase
		// tipos primitivos 
		int inteiro;// 1,2,3
		String palavra;// escrever uma frase
		boolean verdadeiroOufalso;//true ou false
		double numeroReal;//10.5
		int rubensIdade;
		//idade do Rubens, se maior de 18 anos Entra senão não entra.

		// se (condição) for verdadeira{
		//aqui  12
		//}else{
		// o que esta aqui 15
		//}
		rubensIdade = Integer.parseInt(JOptionPane.showInputDialog("Digite a sua idade"));

		if(rubensIdade >=18) {
			System.out.println("o rubens é maior de "+rubensIdade+" pode entrar...");
		}else {
			System.out.println("o rubens é menor de "+ rubensIdade +" não pode entrar");
		}
	}

}
