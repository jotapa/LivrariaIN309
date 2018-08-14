package br.com.livraria.config;

import org.springframework.data.repository.CrudRepository;

import br.com.livraria.modelo.Livro_impresso;

public interface LivroImpressoDAO extends CrudRepository<Livro_impresso, Integer>{

}
