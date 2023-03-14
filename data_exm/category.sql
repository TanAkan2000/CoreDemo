--
-- PostgreSQL database dump
--

-- Dumped from database version 15.1
-- Dumped by pg_dump version 15.1

-- Started on 2023-03-14 17:13:55 +03

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

--
-- TOC entry 3610 (class 0 OID 16558)
-- Dependencies: 218
-- Data for Name: Categories; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public."Categories" ("CategoryID", "CategoryName", "CategoryDescription", "CategoryStatus") VALUES (1, 'deneme', 'deneme', true);
INSERT INTO public."Categories" ("CategoryID", "CategoryName", "CategoryDescription", "CategoryStatus") VALUES (2, 'deneme', 'deneme', true);
INSERT INTO public."Categories" ("CategoryID", "CategoryName", "CategoryDescription", "CategoryStatus") VALUES (3, 'deneme', 'deneme', true);


--
-- TOC entry 3616 (class 0 OID 0)
-- Dependencies: 217
-- Name: Categories_CategoryID_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public."Categories_CategoryID_seq"', 1, false);


-- Completed on 2023-03-14 17:13:55 +03

--
-- PostgreSQL database dump complete
--

