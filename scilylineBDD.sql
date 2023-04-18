-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1
-- Généré le : jeu. 13 oct. 2022 à 23:02
-- Version du serveur : 10.4.22-MariaDB
-- Version de PHP : 8.1.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `scilyline`
--

-- --------------------------------------------------------

--
-- Structure de la table `bateau`
--

CREATE TABLE `bateau` (
  `ID` char(32) NOT NULL,
  `NOM` char(32) NOT NULL,
  `LONGUEUR` char(32) DEFAULT NULL,
  `LARGEUR` char(32) DEFAULT NULL,
  `VITESSE` char(32) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Structure de la table `categorie`
--

CREATE TABLE `categorie` (
  `ID` char(32) NOT NULL,
  `LIBELLE` char(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Structure de la table `client`
--

CREATE TABLE `client` (
  `ID` char(32) NOT NULL,
  `NOM` char(32) NOT NULL,
  `ADRESSE` char(32) DEFAULT NULL,
  `CP` char(32) DEFAULT NULL,
  `VILLE` char(32) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Structure de la table `contenir`
--

CREATE TABLE `contenir` (
  `ID` char(32) NOT NULL,
  `ID_1` char(32) NOT NULL,
  `NBMAX` char(32) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Structure de la table `equipement`
--

CREATE TABLE `equipement` (
  `ID` char(32) NOT NULL,
  `LIBELLE` char(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Structure de la table `liaison`
--

CREATE TABLE `liaison` (
  `ID` char(32) NOT NULL,
  `ID_REGROUPER` char(32) NOT NULL,
  `ID_DEPART` char(32) NOT NULL,
  `ID_ARRIVEE` char(32) NOT NULL,
  `duree` varchar(16) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `liaison`
--

INSERT INTO `liaison` (`ID`, `ID_REGROUPER`, `ID_DEPART`, `ID_ARRIVEE`, `duree`) VALUES
('1', '1', '1', '2', '21'),
('2', '3', '3', '4', '21'),
('3', '4', '4', '3', '23'),
('4', '2', '2', '3', '21'),
('5', '3', '3', '2', '23'),
('6', '1', '1', '4', '29'),
('7', '1', '1', '3', '32');

-- --------------------------------------------------------

--
-- Structure de la table `participer`
--

CREATE TABLE `participer` (
  `ID` char(32) NOT NULL,
  `ID_1` char(32) NOT NULL,
  `NOMBRE` char(32) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Structure de la table `periode`
--

CREATE TABLE `periode` (
  `ID` char(32) NOT NULL,
  `DATEDEBUT` date DEFAULT NULL,
  `DATEFIN` char(32) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Structure de la table `port`
--

CREATE TABLE `port` (
  `ID` char(32) NOT NULL,
  `NOM` char(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `port`
--

INSERT INTO `port` (`ID`, `NOM`) VALUES
('1', 'Palerme'),
('2', 'Ustica'),
('3', 'Stromboli'),
('4', 'Lipari');

-- --------------------------------------------------------

--
-- Structure de la table `proposer`
--

CREATE TABLE `proposer` (
  `ID` char(32) NOT NULL,
  `ID_1` char(32) NOT NULL,
  `QUANTITE` char(32) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Structure de la table `reservation`
--

CREATE TABLE `reservation` (
  `ID` char(32) NOT NULL,
  `ID_RESERVER` char(32) NOT NULL,
  `ID_CONCERNER` char(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Structure de la table `secteur`
--

CREATE TABLE `secteur` (
  `ID` char(32) NOT NULL,
  `LIBELLE` char(32) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `secteur`
--

INSERT INTO `secteur` (`ID`, `LIBELLE`) VALUES
('1', 'Palerme'),
('2', 'Messine'),
('3', 'Millazo'),
('4', 'Napoli');

-- --------------------------------------------------------

--
-- Structure de la table `tarifer`
--

CREATE TABLE `tarifer` (
  `ID` char(32) NOT NULL,
  `ID_1` char(32) NOT NULL,
  `ID_2` char(32) NOT NULL,
  `TARIF` char(32) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Structure de la table `traversee`
--

CREATE TABLE `traversee` (
  `ID` char(32) NOT NULL,
  `ID_REALISER` char(32) NOT NULL,
  `ID_EFFECTUER` char(32) NOT NULL,
  `DATE` date NOT NULL,
  `HEURE` time NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Structure de la table `type`
--

CREATE TABLE `type` (
  `ID` char(32) NOT NULL,
  `ID_CLASSER` char(32) NOT NULL,
  `LIBELLE` char(32) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Index pour les tables déchargées
--

--
-- Index pour la table `bateau`
--
ALTER TABLE `bateau`
  ADD PRIMARY KEY (`ID`);

--
-- Index pour la table `categorie`
--
ALTER TABLE `categorie`
  ADD PRIMARY KEY (`ID`);

--
-- Index pour la table `client`
--
ALTER TABLE `client`
  ADD PRIMARY KEY (`ID`);

--
-- Index pour la table `contenir`
--
ALTER TABLE `contenir`
  ADD PRIMARY KEY (`ID`,`ID_1`),
  ADD KEY `I_FK_CONTENIR_BATEAU` (`ID`),
  ADD KEY `I_FK_CONTENIR_CATEGORIE` (`ID_1`);

--
-- Index pour la table `equipement`
--
ALTER TABLE `equipement`
  ADD PRIMARY KEY (`ID`);

--
-- Index pour la table `liaison`
--
ALTER TABLE `liaison`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `I_FK_LIAISON_SECTEUR` (`ID_REGROUPER`),
  ADD KEY `I_FK_LIAISON_PORT` (`ID_DEPART`),
  ADD KEY `I_FK_LIAISON_PORT1` (`ID_ARRIVEE`);

--
-- Index pour la table `participer`
--
ALTER TABLE `participer`
  ADD PRIMARY KEY (`ID`,`ID_1`),
  ADD KEY `I_FK_PARTICIPER_RESERVATION` (`ID`),
  ADD KEY `I_FK_PARTICIPER_TYPE` (`ID_1`);

--
-- Index pour la table `periode`
--
ALTER TABLE `periode`
  ADD PRIMARY KEY (`ID`);

--
-- Index pour la table `port`
--
ALTER TABLE `port`
  ADD PRIMARY KEY (`ID`);

--
-- Index pour la table `proposer`
--
ALTER TABLE `proposer`
  ADD PRIMARY KEY (`ID`,`ID_1`),
  ADD KEY `I_FK_PROPOSER_BATEAU` (`ID`),
  ADD KEY `I_FK_PROPOSER_EQUIPEMENT` (`ID_1`);

--
-- Index pour la table `reservation`
--
ALTER TABLE `reservation`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `I_FK_RESERVATION_CLIENT` (`ID_RESERVER`),
  ADD KEY `I_FK_RESERVATION_TRAVERSEE` (`ID_CONCERNER`);

--
-- Index pour la table `secteur`
--
ALTER TABLE `secteur`
  ADD PRIMARY KEY (`ID`);

--
-- Index pour la table `tarifer`
--
ALTER TABLE `tarifer`
  ADD PRIMARY KEY (`ID`,`ID_1`,`ID_2`),
  ADD KEY `I_FK_TARIFER_PERIODE` (`ID_1`),
  ADD KEY `I_FK_TARIFER_TYPE` (`ID_2`),
  ADD KEY `I_FK_TARIFER_LIAISON` (`ID`) USING BTREE;

--
-- Index pour la table `traversee`
--
ALTER TABLE `traversee`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `I_FK_TRAVERSEE_LIAISON` (`ID_REALISER`),
  ADD KEY `I_FK_TRAVERSEE_BATEAU` (`ID_EFFECTUER`);

--
-- Index pour la table `type`
--
ALTER TABLE `type`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `I_FK_TYPE_CATEGORIE` (`ID_CLASSER`);

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `contenir`
--
ALTER TABLE `contenir`
  ADD CONSTRAINT `FK_CONTENIR_BATEAU` FOREIGN KEY (`ID`) REFERENCES `bateau` (`ID`),
  ADD CONSTRAINT `FK_CONTENIR_CATEGORIE` FOREIGN KEY (`ID_1`) REFERENCES `categorie` (`ID`);

--
-- Contraintes pour la table `liaison`
--
ALTER TABLE `liaison`
  ADD CONSTRAINT `FK_LIAISON_PORT` FOREIGN KEY (`ID_DEPART`) REFERENCES `port` (`ID`),
  ADD CONSTRAINT `FK_LIAISON_PORT1` FOREIGN KEY (`ID_ARRIVEE`) REFERENCES `port` (`ID`),
  ADD CONSTRAINT `FK_LIAISON_SECTEUR` FOREIGN KEY (`ID_REGROUPER`) REFERENCES `secteur` (`ID`);

--
-- Contraintes pour la table `participer`
--
ALTER TABLE `participer`
  ADD CONSTRAINT `FK_PARTICIPER_RESERVATION` FOREIGN KEY (`ID`) REFERENCES `reservation` (`ID`),
  ADD CONSTRAINT `FK_PARTICIPER_TYPE` FOREIGN KEY (`ID_1`) REFERENCES `type` (`ID`);

--
-- Contraintes pour la table `proposer`
--
ALTER TABLE `proposer`
  ADD CONSTRAINT `FK_PROPOSER_BATEAU` FOREIGN KEY (`ID`) REFERENCES `bateau` (`ID`),
  ADD CONSTRAINT `FK_PROPOSER_EQUIPEMENT` FOREIGN KEY (`ID_1`) REFERENCES `equipement` (`ID`);

--
-- Contraintes pour la table `reservation`
--
ALTER TABLE `reservation`
  ADD CONSTRAINT `FK_RESERVATION_CLIENT` FOREIGN KEY (`ID_RESERVER`) REFERENCES `client` (`ID`),
  ADD CONSTRAINT `FK_RESERVATION_TRAVERSEE` FOREIGN KEY (`ID_CONCERNER`) REFERENCES `traversee` (`ID`);

--
-- Contraintes pour la table `tarifer`
--
ALTER TABLE `tarifer`
  ADD CONSTRAINT `FK_TARIFER_LIAISON` FOREIGN KEY (`ID`) REFERENCES `liaison` (`ID`),
  ADD CONSTRAINT `FK_TARIFER_PERIODE` FOREIGN KEY (`ID_1`) REFERENCES `periode` (`ID`),
  ADD CONSTRAINT `FK_TARIFER_TYPE` FOREIGN KEY (`ID_2`) REFERENCES `type` (`ID`);

--
-- Contraintes pour la table `traversee`
--
ALTER TABLE `traversee`
  ADD CONSTRAINT `FK_TRAVERSEE_BATEAU` FOREIGN KEY (`ID_EFFECTUER`) REFERENCES `bateau` (`ID`),
  ADD CONSTRAINT `FK_TRAVERSEE_LIAISON` FOREIGN KEY (`ID_REALISER`) REFERENCES `liaison` (`ID`);

--
-- Contraintes pour la table `type`
--
ALTER TABLE `type`
  ADD CONSTRAINT `FK_TYPE_CATEGORIE` FOREIGN KEY (`ID_CLASSER`) REFERENCES `categorie` (`ID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
