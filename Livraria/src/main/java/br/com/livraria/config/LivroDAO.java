package br.com.livraria.config;

import org.springframework.data.repository.CrudRepository;

import br.com.livraria.modelo.Livro;

public interface LivroDAO extends CrudRepository<Livro, Integer>{

}