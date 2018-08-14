package br.com.livraria.config;

import org.springframework.data.repository.CrudRepository;

import br.com.livraria.modelo.Autor;

public interface AutorDAO extends CrudRepository<Autor, Integer>{

}
