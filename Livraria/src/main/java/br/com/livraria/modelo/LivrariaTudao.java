package br.com.livraria.modelo;

import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;

import org.springframework.format.annotation.NumberFormat;

@Entity
public class LivrariaTudao {

	@Id
	@GeneratedValue(strategy=GenerationType.IDENTITY)
	private int idLivro;
	private String titulo;
	private String Autor;
	private String Editora;
	
	private String Categoria;
	private String isbn;
	private String capa;
	
	@NumberFormat(pattern = "#,##.00")
	private Double preco;

	public LivrariaTudao() {
		super();
		// TODO Auto-generated constructor stub
	}

	public LivrariaTudao(int idLivro, String titulo, String autor, String editora, String categoria, String isbn,
			String capa, Double preco) {
		super();
		this.idLivro = idLivro;
		this.titulo = titulo;
		Autor = autor;
		Editora = editora;
		Categoria = categoria;
		this.isbn = isbn;
		this.capa = capa;
		this.preco = preco;
	}

	public int getIdLivro() {
		return idLivro;
	}

	public void setIdLivro(int idLivro) {
		this.idLivro = idLivro;
	}

	public String getTitulo() {
		return titulo;
	}

	public void setTitulo(String titulo) {
		this.titulo = titulo;
	}

	public String getAutor() {
		return Autor;
	}

	public void setAutor(String autor) {
		Autor = autor;
	}

	public String getEditora() {
		return Editora;
	}

	public void setEditora(String editora) {
		Editora = editora;
	}

	public String getCategoria() {
		return Categoria;
	}

	public void setCategoria(String categoria) {
		Categoria = categoria;
	}

	public String getIsbn() {
		return isbn;
	}

	public void setIsbn(String isbn) {
		this.isbn = isbn;
	}

	public String getCapa() {
		return capa;
	}

	public void setCapa(String capa) {
		this.capa = capa;
	}

	public Double getPreco() {
		return preco;
	}

	public void setPreco(Double preco) {
		this.preco = preco;
	}
	
	
		
	


}


