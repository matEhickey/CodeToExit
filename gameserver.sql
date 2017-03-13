-- phpMyAdmin SQL Dump
-- version 4.6.5.2deb1
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Generation Time: Feb 17, 2017 at 03:08 AM
-- Server version: 5.6.30-1
-- PHP Version: 7.0.14-2

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `gameserver`
--

-- --------------------------------------------------------

--
-- Table structure for table `execution`
--

CREATE TABLE `execution` (
  `id` int(11) NOT NULL,
  `player_id` int(11) NOT NULL,
  `problem_id` int(11) NOT NULL,
  `language` text NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `execution`
--

INSERT INTO `execution` (`id`, `player_id`, `problem_id`, `language`) VALUES
(1, 1, 3, 'c'),
(2, 0, 0, ''),
(3, 0, 0, ''),
(4, 1, 1, 'C'),
(5, 1, 1, 'C'),
(6, 1, 1, 'C'),
(7, 1, 1, 'C'),
(8, 1, 1, 'C'),
(9, 1, 1, 'C'),
(10, 1, 1, 'C'),
(11, 1, 1, 'C'),
(12, 1, 1, 'C'),
(13, 1, 1, 'C'),
(14, 1, 1, 'C'),
(15, 1, 1, 'C'),
(16, 1, 1, 'C'),
(17, 1, 1, 'C'),
(18, 1, 1, 'C'),
(19, 1, 1, 'C'),
(20, 1, 1, 'C'),
(21, 1, 1, 'C'),
(22, 1, 1, 'C'),
(23, 1, 1, 'C'),
(24, 1, 1, 'C'),
(25, 1, 1, 'C'),
(26, 1, 10, 'C'),
(27, 10, 1, 'C'),
(28, 10, 1, 'cpp'),
(29, 10, 1, 'c'),
(30, 10, 1, 'c'),
(31, 10, 1, 'c'),
(32, 0, 0, ''),
(33, 14, 1, 'c'),
(34, 14, 1, 'c'),
(35, 14, 1, 'c'),
(36, 14, 1, 'c'),
(37, 14, 1, 'c'),
(38, 14, 1, 'c'),
(39, 14, 1, 'c'),
(40, 14, 1, 'c'),
(41, 14, 1, 'c'),
(42, 14, 1, 'c'),
(43, 14, 1, 'c'),
(44, 14, 1, 'c'),
(45, 14, 1, 'c'),
(46, 14, 1, 'c'),
(47, 14, 1, 'c'),
(48, 14, 1, 'c'),
(49, 14, 1, 'java'),
(50, 14, 1, 'java'),
(51, 14, 1, 'java'),
(52, 14, 1, 'c'),
(53, 14, 1, 'c'),
(54, 14, 1, 'c'),
(55, 14, 1, 'c'),
(56, 14, 1, 'c'),
(57, 14, 1, 'c'),
(58, 14, 1, 'c'),
(59, 14, 1, 'c'),
(60, 14, 1, 'c'),
(61, 14, 1, 'c'),
(62, 14, 1, 'c'),
(63, 14, 1, 'c'),
(64, 14, 1, 'c'),
(65, 14, 1, 'c'),
(66, 14, 1, 'c'),
(67, 14, 1, 'c'),
(68, 14, 1, 'c'),
(69, 14, 1, 'c'),
(70, 14, 1, 'c'),
(71, 14, 1, 'java'),
(72, 14, 1, 'java'),
(73, 14, 1, 'java'),
(74, 14, 1, 'java'),
(75, 14, 1, 'java'),
(76, 14, 1, 'java'),
(77, 14, 1, 'java'),
(78, 14, 1, 'java'),
(79, 14, 1, 'java'),
(80, 14, 1, 'java'),
(81, 14, 1, 'java'),
(82, 14, 1, 'java'),
(83, 14, 1, 'java'),
(84, 14, 1, 'java'),
(85, 14, 1, 'java'),
(86, 14, 1, 'java'),
(87, 14, 1, 'java'),
(88, 14, 1, 'c'),
(89, 14, 1, 'java'),
(90, 14, 1, 'c'),
(91, 14, 1, 'c'),
(92, 14, 1, 'c'),
(93, 14, 1, 'c'),
(94, 14, 1, 'c'),
(95, 14, 1, 'c'),
(96, 14, 1, 'java'),
(97, 14, 1, 'c'),
(98, 14, 1, 'c'),
(99, 14, 1, 'c'),
(100, 14, 1, 'c'),
(101, 14, 1, 'c'),
(102, 14, 1, 'c'),
(103, 14, 1, 'c'),
(104, 14, 1, 'c'),
(105, 14, 1, 'c'),
(106, 14, 1, 'c'),
(107, 14, 1, 'c'),
(108, 14, 1, 'c'),
(109, 14, 1, 'c'),
(110, 14, 1, 'c'),
(111, 14, 1, 'c'),
(112, 14, 1, 'c'),
(113, 14, 1, 'c'),
(114, 14, 1, 'c'),
(115, 14, 1, 'c'),
(116, 14, 1, 'c'),
(117, 14, 1, 'c'),
(118, 14, 1, 'c'),
(119, 14, 1, 'c'),
(120, 14, 1, 'c'),
(121, 14, 1, 'c'),
(122, 14, 1, 'c'),
(123, 14, 1, 'c'),
(124, 14, 1, 'c'),
(125, 14, 1, 'c'),
(126, 14, 1, 'c'),
(127, 14, 1, 'c'),
(128, 14, 1, 'c'),
(129, 14, 1, 'c'),
(130, 14, 1, 'c'),
(131, 14, 1, 'c'),
(132, 14, 1, 'c'),
(133, 14, 1, 'c'),
(134, 14, 1, 'c'),
(135, 14, 1, 'c'),
(136, 14, 1, 'c'),
(137, 14, 1, 'c'),
(138, 14, 1, 'c'),
(139, 14, 1, 'c'),
(140, 14, 1, 'c'),
(141, 14, 1, 'c'),
(142, 14, 1, 'c'),
(143, 14, 1, 'c'),
(144, 14, 1, 'c'),
(145, 14, 1, 'c'),
(146, 14, 1, 'c'),
(147, 14, 1, 'c'),
(148, 14, 1, 'c'),
(149, 14, 1, 'c'),
(150, 14, 1, 'c'),
(151, 14, 1, 'c'),
(152, 14, 1, 'c'),
(153, 14, 1, 'c'),
(154, 14, 1, 'c'),
(155, 14, 1, 'c'),
(156, 14, 1, 'c'),
(157, 14, 1, 'c'),
(158, 14, 1, 'c'),
(159, 14, 1, 'c'),
(160, 14, 1, 'c'),
(161, 14, 1, 'c'),
(162, 14, 1, 'c'),
(163, 14, 1, 'c'),
(164, 15, 1, 'c'),
(165, 14, 1, 'c'),
(166, 14, 1, 'c'),
(167, 14, 1, 'c'),
(168, 14, 1, 'c'),
(169, 14, 1, 'c'),
(170, 14, 1, 'c'),
(171, 14, 1, 'c'),
(172, 14, 1, 'c'),
(173, 14, 1, 'c'),
(174, 14, 1, 'c'),
(175, 14, 1, 'c'),
(176, 14, 1, 'c'),
(177, 14, 1, 'c'),
(178, 14, 1, 'c'),
(179, 14, 1, 'c'),
(180, 14, 1, 'c'),
(181, 14, 1, 'c'),
(182, 14, 1, 'c'),
(183, 14, 1, 'c'),
(184, 14, 1, 'c'),
(185, 14, 1, 'c'),
(186, 14, 1, 'c'),
(187, 14, 1, 'c'),
(188, 14, 1, 'c'),
(189, 14, 1, 'c'),
(190, 14, 1, 'c'),
(191, 14, 1, 'c'),
(192, 14, 1, 'c'),
(193, 14, 1, 'c'),
(194, 14, 1, 'c'),
(195, 14, 1, 'c'),
(196, 14, 1, 'c'),
(197, 14, 1, 'c'),
(198, 14, 1, 'c'),
(199, 14, 1, 'c'),
(200, 14, 1, 'c'),
(201, 14, 1, 'c'),
(202, 14, 1, 'c'),
(203, 14, 1, 'c'),
(204, 14, 1, 'c'),
(205, 14, 1, 'c'),
(206, 14, 1, 'c'),
(207, 14, 1, 'c'),
(208, 14, 1, 'c'),
(209, 14, 1, 'c'),
(210, 14, 1, 'c'),
(211, 14, 1, 'c'),
(212, 14, 1, 'c'),
(213, 14, 1, 'c'),
(214, 14, 1, 'c'),
(215, 15, 1, 'c'),
(216, 15, 2, 'c'),
(217, 15, 2, 'cpp'),
(218, 14, 1, 'c'),
(219, 14, 1, 'c'),
(220, 14, 1, 'c'),
(221, 14, 1, 'c'),
(222, 14, 1, 'c'),
(223, 14, 1, 'c'),
(224, 14, 1, 'c'),
(225, 15, 1, 'c'),
(226, 15, 1, 'c'),
(227, 14, 1, 'c'),
(228, 14, 1, 'c'),
(229, 14, 1, 'c'),
(230, 14, 1, 'c'),
(231, 14, 1, 'c'),
(232, 14, 1, 'c'),
(233, 14, 1, 'c'),
(234, 14, 1, 'c'),
(235, 14, 1, 'c'),
(236, 14, 1, 'c'),
(237, 14, 1, 'c'),
(238, 14, 1, 'c'),
(239, 14, 1, 'c'),
(240, 14, 1, 'c'),
(241, 14, 1, 'c'),
(242, 14, 1, 'c'),
(243, 15, 1, 'c'),
(244, 15, 1, 'c'),
(245, 15, 1, 'c'),
(246, 15, 1, 'c'),
(247, 15, 1, 'c'),
(248, 15, 1, 'c'),
(249, 15, 1, 'c'),
(250, 15, 1, 'c'),
(251, 15, 1, 'c'),
(252, 15, 1, 'c'),
(253, 15, 1, 'c'),
(254, 14, 1, 'c'),
(255, 14, 2, 'java'),
(256, 14, 1, 'java'),
(257, 14, 1, 'java'),
(258, 14, 1, 'java'),
(259, 14, 1, 'c'),
(260, 14, 1, 'c'),
(261, 14, 1, 'c'),
(262, 14, 1, 'c'),
(263, 14, 1, 'c'),
(264, 15, 1, 'c'),
(265, 15, 1, 'c'),
(266, 15, 1, 'c'),
(267, 15, 1, 'c'),
(268, 15, 1, 'c'),
(269, 15, 2, 'c'),
(270, 15, 1, 'c'),
(271, 15, 1, 'c'),
(272, 15, 1, 'c'),
(273, 15, 1, 'c'),
(274, 15, 1, 'c'),
(275, 15, 1, 'c'),
(276, 15, 1, 'c'),
(277, 14, 1, 'java'),
(278, 14, 1, 'java'),
(279, 14, 1, 'c'),
(280, 14, 1, 'java'),
(281, 14, 1, 'java'),
(282, 14, 1, 'java'),
(283, 14, 1, 'java'),
(284, 14, 1, 'java'),
(285, 14, 1, 'java'),
(286, 14, 1, 'java'),
(287, 14, 1, 'java'),
(288, 14, 1, 'java'),
(289, 14, 1, 'java'),
(290, 14, 1, 'java'),
(291, 14, 1, 'c'),
(292, 14, 1, 'java'),
(293, 14, 1, 'java'),
(294, 14, 1, 'java'),
(295, 14, 1, 'java'),
(296, 14, 1, 'java'),
(297, 14, 1, 'java'),
(298, 14, 1, 'java'),
(299, 14, 1, 'java'),
(300, 14, 1, 'java'),
(301, 14, 1, 'java'),
(302, 14, 1, 'java'),
(303, 14, 1, 'java'),
(304, 14, 1, 'java'),
(305, 14, 1, 'java'),
(306, 14, 1, 'java'),
(307, 14, 1, 'java'),
(308, 14, 1, 'c'),
(309, 11, 1, 'c'),
(310, 11, 1, 'c'),
(311, 11, 2, 'c'),
(312, 11, 2, 'c'),
(313, 11, 2, 'c'),
(314, 11, 2, 'c'),
(315, 11, 1, 'c'),
(316, 11, 1, 'c'),
(317, 11, 1, 'c'),
(318, 11, 1, 'c'),
(319, 11, 1, 'c'),
(320, 11, 1, 'c'),
(321, 11, 1, 'c');

-- --------------------------------------------------------

--
-- Table structure for table `player`
--

CREATE TABLE `player` (
  `id` int(11) NOT NULL,
  `date` text NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `player`
--

INSERT INTO `player` (`id`, `date`) VALUES
(1, '1485018073'),
(2, '1485018079'),
(3, '1485018080'),
(4, '1485018080'),
(5, '1485018081'),
(6, '1485055940'),
(7, '1485055944'),
(8, '1485055961'),
(9, '1485056269'),
(10, '1485056721'),
(11, '1487027333');

-- --------------------------------------------------------

--
-- Table structure for table `problem`
--

CREATE TABLE `problem` (
  `id` int(11) NOT NULL,
  `name` text NOT NULL,
  `description` text NOT NULL,
  `beginC` longtext NOT NULL,
  `beginJava` longtext NOT NULL,
  `beginCPP` longtext NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `problem`
--

INSERT INTO `problem` (`id`, `name`, `description`, `beginC`, `beginJava`, `beginCPP`) VALUES
(1, 'Tri croissant', 'Pour acceder au niveau suivant, il vous faut trier un tableau de valeur.\r\nChaque case represente une marche de l\'escalier devant vous.', '//Squelette de programme a completer pour reussir le niveau 1\n#include <stdio.h>\n#include <stdlib.h>\n\nint compare( const void* a, const void* b)\n{\n   int int_a = * ( (int*) a );\n   int int_b = * ( (int*) b );\n\n   // an easy expression for comparing\n   return (int_a > int_b) - (int_a < int_b);\n}\n\nvoid main(){\n	\n	int *tab = NULL;\n	int i = 0;\n	int a;\n	int nStep;\n	\n	scanf(\"%i\",&nStep); //get numbers of step\n	\n	tab = malloc(sizeof(int)*nStep);\n	while(scanf(\"%i\",&a) != EOF){\n		tab[i] = a;		//store value of each\n		i++;\n	}\n	\n	//qsort( tab, nStep, sizeof(int), compare );\n	\n	for(i=0;i<nStep;i++){\n		printf(\"%i \",tab[i]);\n	}\n	\n	free(tab);\n}\n\n\n\n\n\n\n\n\n\n\n', 'import java.util.*;\r\n\r\npublic class scriptUser {\r\n\r\n    public static void main(String[] args) {\r\n    	Scanner scanner = new Scanner(System.in);\r\n    	\r\n        int nStep = scanner.nextInt();\r\n        int steps[] = new int[nStep];\r\n        \r\n        for(int i = 0; i< nStep; i++){\r\n        	steps[i]=scanner.nextInt();\r\n        }\r\n        \r\n        String result = \"\";\r\n        for(int i : steps){\r\n        	result += i+\" \";\r\n        }\r\n        System.out.println(result);\r\n    }\r\n\r\n}\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n', '#include <iostream>    // declarations for I/O\n\nint main()            // main function main()\n{\n    /* print `Hello, World!\' on standard output channel std::cout\n     * followed by an endline (std::endl)\n     */\n    std::cout << \"Hello, World!\" << std::endl;\n}\n\n\n\n\n\n\n\n\n\n'),
(2, 'Maze', 'Il s\'agit de resoudre le probleme de graphe permettant de sortir du labyrynthe', '//Squelette de programme a completer pour reussir le niveau 2\n#include <stdio.h>\n#include <stdlib.h>\n\nint compare( const void* a, const void* b)\n{\n   int int_a = * ( (int*) a );\n   int int_b = * ( (int*) b );\n\n   // an easy expression for comparing\n   return (int_a > int_b) - (int_a < int_b);\n}\n\nvoid main(){\n	\n	int *tab = NULL;\n	int i = 0;\n	int a;\n	int nStep;\n	\n	scanf(\"%i\",&nStep); //get numbers of step\n	\n	tab = malloc(sizeof(int)*nStep);\n	while(scanf(\"%i\",&a) != EOF){\n		tab[i] = a;		//store value of each\n		i++;\n	}\n	\n	//qsort( tab, nStep, sizeof(int), compare );\n	\n	for(i=0;i<nStep;i++){\n		printf(\"%i \",tab[i]);\n	}\n	\n	free(tab);\n}\n\n\n\n\n\n\n\n\n\n\n', 'import java.util.*;\r\n\r\npublic class scriptUser {\r\n\r\n    public static void main(String[] args) {\r\n    	Scanner scanner = new Scanner(System.in);\r\n    	\r\n        int nStep = scanner.nextInt();\r\n        int steps[] = new int[nStep];\r\n        \r\n        for(int i = 0; i< nStep; i++){\r\n        	steps[i]=scanner.nextInt();\r\n        }\r\n        \r\n        String result = \"\";\r\n        for(int i : steps){\r\n        	result += i+\" \";\r\n        }\r\n        System.out.println(result);\r\n    }\r\n\r\n}\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n', '#include <iostream>    // declarations for I/O\r\n\r\nint main()            // main function main()\r\n{\r\n    /* print `Hello, World!\' on standard output channel std::cout\r\n     * followed by an endline (std::endl)\r\n     */\r\n    std::cout << \"Hello, World!\" << std::endl;\r\n}');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `execution`
--
ALTER TABLE `execution`
  ADD UNIQUE KEY `id_2` (`id`),
  ADD KEY `id` (`id`);

--
-- Indexes for table `player`
--
ALTER TABLE `player`
  ADD UNIQUE KEY `id_2` (`id`),
  ADD KEY `id` (`id`);

--
-- Indexes for table `problem`
--
ALTER TABLE `problem`
  ADD UNIQUE KEY `id_2` (`id`),
  ADD KEY `id` (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `execution`
--
ALTER TABLE `execution`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=322;
--
-- AUTO_INCREMENT for table `player`
--
ALTER TABLE `player`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;
--
-- AUTO_INCREMENT for table `problem`
--
ALTER TABLE `problem`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
