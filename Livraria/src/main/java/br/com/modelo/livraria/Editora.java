package br.com.modelo.livraria;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;

@Entity
public class Editora {

	@Id
	@GeneratedValue(strategy=GenerationType.AUTO)
	private int idEditora;

	@Column
	private String nome;
	
	public Editora() {
		super();
		// TODO Auto-generated constructor stub
	}

	public Editora(int idEditora, String nome) {
		super();
		this.idEditora = idEditora;
		this.nome = nome;
	}

	public int getIdEditora() {
		return idEditora;
	}

	public void setIdEditora(int idEditora) {
		this.idEditora = idEditora;
	}

	public String getNome() {
		return nome;
	}

	public void setNome(String nome) {
		this.nome = nome;
	}
	
}
