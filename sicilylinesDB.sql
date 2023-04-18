-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1
-- Généré le : mer. 19 avr. 2023 à 01:25
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
-- Base de données : `scilylinees`
--

-- --------------------------------------------------------

--
-- Structure de la table `bateau`
--

CREATE TABLE `bateau` (
  `ID` int(32) NOT NULL,
  `NOM` char(32) NOT NULL,
  `LONGUEUR` char(32) DEFAULT NULL,
  `LARGEUR` char(32) DEFAULT NULL,
  `VITESSE` char(32) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `bateau`
--

INSERT INTO `bateau` (`ID`, `NOM`, `LONGUEUR`, `LARGEUR`, `VITESSE`) VALUES
(1, 'Eduardo', '37,20m', '8,60m', '20 noeuds'),
(2, 'Platone', '25m', '7m', '16 noeuds');

-- --------------------------------------------------------

--
-- Structure de la table `categorie`
--

CREATE TABLE `categorie` (
  `ID` int(32) NOT NULL,
  `LIBELLE` char(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Structure de la table `client`
--

CREATE TABLE `client` (
  `ID` int(32) NOT NULL,
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
  `ID` int(32) NOT NULL,
  `ID_1` int(32) NOT NULL,
  `NBMAX` int(32) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Structure de la table `equipement`
--

CREATE TABLE `equipement` (
  `ID` int(32) NOT NULL,
  `LIBELLE` char(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `equipement`
--

INSERT INTO `equipement` (`ID`, `LIBELLE`) VALUES
(1, 'Accès Handicapé'),
(2, 'Bar'),
(3, 'Pont Promenade'),
(4, 'Salon Vidéo');

-- --------------------------------------------------------

--
-- Structure de la table `liaison`
--

CREATE TABLE `liaison` (
  `ID` int(32) NOT NULL,
  `ID_REGROUPER` int(32) NOT NULL,
  `ID_DEPART` int(32) NOT NULL,
  `ID_ARRIVEE` int(32) NOT NULL,
  `DUREE` char(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `liaison`
--

INSERT INTO `liaison` (`ID`, `ID_REGROUPER`, `ID_DEPART`, `ID_ARRIVEE`, `DUREE`) VALUES
(1, 2, 3, 6, '81'),
(2, 3, 1, 7, '11'),
(3, 4, 2, 4, '12'),
(5, 1, 1, 6, '31');

-- --------------------------------------------------------

--
-- Structure de la table `participer`
--

CREATE TABLE `participer` (
  `ID` int(32) NOT NULL,
  `ID_1` int(32) NOT NULL,
  `NOMBRE` char(32) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Structure de la table `periode`
--

CREATE TABLE `periode` (
  `ID` int(32) NOT NULL,
  `DATEDEBUT` date DEFAULT NULL,
  `DATEFIN` char(32) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Structure de la table `port`
--

CREATE TABLE `port` (
  `ID` int(32) NOT NULL,
  `NOM` char(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `port`
--

INSERT INTO `port` (`ID`, `NOM`) VALUES
(1, 'Palerme'),
(2, 'Messine'),
(3, 'Milazzo'),
(4, 'Trapani'),
(5, 'Ustica'),
(6, 'Lipari'),
(7, 'Stromboli');

-- --------------------------------------------------------

--
-- Structure de la table `proposer`
--

CREATE TABLE `proposer` (
  `ID` int(32) NOT NULL,
  `ID_1` int(32) NOT NULL,
  `QUANTITE` int(32) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Structure de la table `reservation`
--

CREATE TABLE `reservation` (
  `ID` int(32) NOT NULL,
  `ID_RESERVER` int(32) NOT NULL,
  `ID_CONCERNER` int(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Structure de la table `secteur`
--

CREATE TABLE `secteur` (
  `ID` int(32) NOT NULL,
  `LIBELLE` char(32) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `secteur`
--

INSERT INTO `secteur` (`ID`, `LIBELLE`) VALUES
(1, 'Palerme'),
(2, 'Messine'),
(3, 'Milazzo'),
(4, 'Trapani');

-- --------------------------------------------------------

--
-- Structure de la table `tarifer`
--

CREATE TABLE `tarifer` (
  `ID` int(32) NOT NULL,
  `ID_1` int(32) NOT NULL,
  `ID_2` int(32) NOT NULL,
  `TARIF` int(32) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Structure de la table `traversee`
--

CREATE TABLE `traversee` (
  `ID` int(32) NOT NULL,
  `ID_REALISER` int(32) NOT NULL,
  `ID_EFFECTUER` int(32) NOT NULL,
  `DATE` date NOT NULL,
  `HEURE` time NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `traversee`
--

INSERT INTO `traversee` (`ID`, `ID_REALISER`, `ID_EFFECTUER`, `DATE`, `HEURE`) VALUES
(1, 1, 1, '2022-11-09', '00:48:07');

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
  ADD KEY `I_FK_LIAISON_PORT` (`ID_DEPART`),
  ADD KEY `I_FK_LIAISON_PORT1` (`ID_ARRIVEE`),
  ADD KEY `ID_REGROUPER` (`ID_REGROUPER`);

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
  ADD KEY `I_FK_TARIFER_LIAISON` (`ID`),
  ADD KEY `I_FK_TARIFER_PERIODE` (`ID_1`),
  ADD KEY `I_FK_TARIFER_TYPE` (`ID_2`);

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
-- AUTO_INCREMENT pour les tables déchargées
--

--
-- AUTO_INCREMENT pour la table `liaison`
--
ALTER TABLE `liaison`
  MODIFY `ID` int(32) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT pour la table `secteur`
--
ALTER TABLE `secteur`
  MODIFY `ID` int(32) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `contenir`
--
ALTER TABLE `contenir`
  ADD CONSTRAINT `FK_CONTENIR_BATEAU` FOREIGN KEY (`ID`) REFERENCES `bateau` (`ID`);

--
-- Contraintes pour la table `liaison`
--
ALTER TABLE `liaison`
  ADD CONSTRAINT `liaison_ibfk_1` FOREIGN KEY (`ID_REGROUPER`) REFERENCES `secteur` (`ID`),
  ADD CONSTRAINT `liaison_ibfk_2` FOREIGN KEY (`ID_DEPART`) REFERENCES `port` (`ID`),
  ADD CONSTRAINT `liaison_ibfk_3` FOREIGN KEY (`ID_ARRIVEE`) REFERENCES `port` (`ID`);

--
-- Contraintes pour la table `participer`
--
ALTER TABLE `participer`
  ADD CONSTRAINT `FK_PARTICIPER_RESERVATION` FOREIGN KEY (`ID`) REFERENCES `reservation` (`ID`);

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
  ADD CONSTRAINT `FK_TARIFER_PERIODE` FOREIGN KEY (`ID_1`) REFERENCES `periode` (`ID`);

--
-- Contraintes pour la table `traversee`
--
ALTER TABLE `traversee`
  ADD CONSTRAINT `FK_TRAVERSEE_BATEAU` FOREIGN KEY (`ID_EFFECTUER`) REFERENCES `bateau` (`ID`),
  ADD CONSTRAINT `FK_TRAVERSEE_LIAISON` FOREIGN KEY (`ID_REALISER`) REFERENCES `liaison` (`ID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
