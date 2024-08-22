SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema banco_sapt
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `banco_sapt` DEFAULT CHARACTER SET utf8 ;
USE `banco_sapt` ;

-- -----------------------------------------------------
-- Table `banco_sapt`.`Usuarios`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `banco_sapt`.`Usuarios` ;

CREATE TABLE IF NOT EXISTS `banco_sapt`.`Usuarios` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `login` VARCHAR(60) NOT NULL,
  `senha` VARCHAR(45) NOT NULL,
  `nivel_acesso` TINYINT NOT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `banco_sapt`.`Avaliacoes`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `banco_sapt`.`Avaliacoes` ;

CREATE TABLE IF NOT EXISTS `banco_sapt`.`Avaliacoes` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `data_avaliacao` DATETIME NOT NULL,
  `tipo_avaliacao` VARCHAR(45) NOT NULL,
  `segmento` VARCHAR(45) NOT NULL,
  `municipio` VARCHAR(45) NOT NULL,
  `Usuarios_id` INT NOT NULL,
  PRIMARY KEY (`id`),
  INDEX `fk_Avaliacoes_Usuarios1_idx` (`Usuarios_id` ASC) VISIBLE,
  CONSTRAINT `fk_Avaliacoes_Usuarios1`
    FOREIGN KEY (`Usuarios_id`)
    REFERENCES `banco_sapt`.`Usuarios` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `banco_sapt`.`Criterios`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `banco_sapt`.`Criterios` ;

CREATE TABLE IF NOT EXISTS `banco_sapt`.`Criterios` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `matriz` VARCHAR(50) NOT NULL,
  `dimensao` VARCHAR(80) NULL,
  `pergunta` VARCHAR(400) NOT NULL,
  `classificacao` VARCHAR(15) NOT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `banco_sapt`.`Respostas`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `banco_sapt`.`Respostas` ;

CREATE TABLE IF NOT EXISTS `banco_sapt`.`Respostas` (
  `Avaliacoes_id` INT NOT NULL,
  `resposta` TINYINT NOT NULL,
  `link` VARCHAR(255) NULL,
  `Criterios_id` INT NOT NULL,
  PRIMARY KEY (`Avaliacoes_id`, `Criterios_id`),
  INDEX `fk_Respostas_Criterios1_idx` (`Criterios_id` ASC) VISIBLE,
  CONSTRAINT `fk_Respostas_Avaliacoes1`
    FOREIGN KEY (`Avaliacoes_id`)
    REFERENCES `banco_sapt`.`Avaliacoes` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Respostas_Criterios1`
    FOREIGN KEY (`Criterios_id`)
    REFERENCES `banco_sapt`.`Criterios` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `banco_sapt`.`Login_Log`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `banco_sapt`.`Login_Log` ;

CREATE TABLE IF NOT EXISTS `banco_sapt`.`Login_Log` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `entrada` DATETIME NOT NULL,
  `saida` DATETIME NOT NULL,
  `login` VARCHAR(60) NOT NULL,
  `Usuarios_id` INT NOT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;

# INSERTS
# Critérios Reduzidos
INSERT INTO criterios (matriz, dimensao, pergunta, classificacao)
VALUES
('MATRIZ COMUM', '1. INFORMAÇÕES PRIORITÁRIAS', '1.1 A entidade pública possui sítio oficial e/ou portal da transparência próprio ou compartilhado na internet?', 'Essencial.'),
('MATRIZ COMUM', '1. INFORMAÇÕES PRIORITÁRIAS', '1.2 O site contém ferramenta de pesquisa de conteúdo que permita o acesso à informação?', 'Obrigatória.'),
('MATRIZ COMUM', '2. INFORMAÇÕES INSTITUCIONAIS', '2.1 Competências.', 'Obrigatória.'),
('MATRIZ COMUM', '2. INFORMAÇÕES INSTITUCIONAIS', '2.2 Estrutura organizacional.', 'Obrigatória.'),
('MATRIZ COMUM', '2. INFORMAÇÕES INSTITUCIONAIS', '2.3 Identificação dos responsáveis.', 'Obrigatória.'),
('MATRIZ COMUM', '2. INFORMAÇÕES INSTITUCIONAIS', '2.4 Endereços.', 'Obrigatória.'),
('MATRIZ ESPECÍFICA: PODER EXECUTIVO', '14. INSTRUMENTOS DA GESTÃO FISCAL E DO PLANEJAMENTO', '14.1 Existência de PPA (Lei do Plano Plurianual).', 'Essencial.'),
('MATRIZ ESPECÍFICA: PODER EXECUTIVO', '14. INSTRUMENTOS DA GESTÃO FISCAL E DO PLANEJAMENTO', '14.2 Existência do Anexo do PPA.', 'Essencial.'),
('MATRIZ ESPECÍFICA: PODER EXECUTIVO', '14. INSTRUMENTOS DA GESTÃO FISCAL E DO PLANEJAMENTO', '14.3 Existência de LDO (Lei de Diretrizes Orçamentárias).', 'Essencial.'),
('MATRIZ ESPECÍFICA: PODER EXECUTIVO', '14. INSTRUMENTOS DA GESTÃO FISCAL E DO PLANEJAMENTO', '14.4 Existência do Anexo da LDO.', 'Essencial.'),
('MATRIZ ESPECÍFICA: PODER LEGISLATIVO', NULL, '17.1 Leis federais/estaduais/municipais (conforme o caso) e atos infralegais (resoluções/decretos) publicados no ano corrente.', 'Obrigatória.'),
('MATRIZ ESPECÍFICA: PODER LEGISLATIVO', NULL, '17.2 Leis federais/estaduais/municipais (conforme o caso) e atos infralegais (resoluções/decretos) publicados nos 3 anos que antecedem ao da pesquisa (no mínimo).', 'Obrigatória.'),
('MATRIZ ESPECÍFICA: PODER LEGISLATIVO', NULL, '17.3 Possibilidade de acessar as leis federais/estaduais/ municipais já editadas, de acordo com a numeração, a data, as palavraschave ou o texto livre.', 'Obrigatória.'),
('MATRIZ ESPECÍFICA: PODER LEGISLATIVO', NULL, '17.4 Divulga informações atualizadas sobre cotas para exercício da atividade parlamentar/verba indenizatória.', 'Recomendada.');

# Usuários Padrão
INSERT INTO usuarios (login, senha, nivel_acesso)
VALUES 
('uriel@ifma.com', 'uriel', 1),
('pedro@ifma.com', 'pedro', 2),
('benjamin@ifma.com','benjamin', 2);