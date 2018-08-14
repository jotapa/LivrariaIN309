package br.com.livraria.config;

import org.springframework.data.repository.CrudRepository;

import br.com.livraria.modelo.Livro_digital;

public interface LivroDigitalDAO extends CrudRepository<Livro_digital, Integer>{

}
