--
-- PostgreSQL database dump
--

-- Dumped from database version 15.1
-- Dumped by pg_dump version 15.1

-- Started on 2023-03-14 17:14:28 +03

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
-- TOC entry 3610 (class 0 OID 16574)
-- Dependencies: 222
-- Data for Name: Writers; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public."Writers" ("WriterID", "WriterName", "WriterAbout", "WriterImage", "WriterMail", "WriterPassword", "WriterStatus") VALUES (2, 'deneme', 'deneme', 'deneme', 'deneme', 'deneme', true);
INSERT INTO public."Writers" ("WriterID", "WriterName", "WriterAbout", "WriterImage", "WriterMail", "WriterPassword", "WriterStatus") VALUES (1, 'deneme1', 'deneme1', 'deneme1', 'deneme1@gmail.com', 'deneme1', true);
INSERT INTO public."Writers" ("WriterID", "WriterName", "WriterAbout", "WriterImage", "WriterMail", "WriterPassword", "WriterStatus") VALUES (3, 'deneme2', 'deneme2', 'deneme2', 'deneme2', 'deneme2', true);


--
-- TOC entry 3616 (class 0 OID 0)
-- Dependencies: 221
-- Name: Writers_WriterID_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public."Writers_WriterID_seq"', 1, false);


-- Completed on 2023-03-14 17:14:29 +03

--
-- PostgreSQL database dump complete
--

