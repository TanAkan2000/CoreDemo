--
-- PostgreSQL database dump
--

-- Dumped from database version 15.1
-- Dumped by pg_dump version 15.1

-- Started on 2023-03-14 17:12:35 +03

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
-- TOC entry 3614 (class 0 OID 16582)
-- Dependencies: 224
-- Data for Name: Blogs; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public."Blogs" ("BlogId", "BlogTitle", "BlogContent", "BlogThumbnailImage", "BlogImage", "BlogCreateDate", "BlogStatus", "CategoryID", "WriterID") VALUES (1, 'deneme', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur venenatis pretium tincidunt. Fusce condimentum nisl non tempus efficitur. Vestibulum non lectus consectetur, ultricies est a, auctor massa. Aliquam sit amet mauris vitae felis bibendum posuere. Pellentesque eget posuere tellus. Vestibulum vestibulum ipsum ut eros vulputate, vitae mattis sapien sollicitudin. Integer fringilla, neque vitae viverra lobortis, felis felis faucibus turpis, at tincidunt diam elit id urna. Phasellus dignissim purus quis libero malesuada, et blandit lectus pharetra. Praesent et ante vel risus scelerisque porttitor.', 'deneme', '/web/images/b2.jpg', '2004-10-19 10:23:54+03', true, 1, 1);
INSERT INTO public."Blogs" ("BlogId", "BlogTitle", "BlogContent", "BlogThumbnailImage", "BlogImage", "BlogCreateDate", "BlogStatus", "CategoryID", "WriterID") VALUES (2, 'deneme', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur venenatis pretium tincidunt. Fusce condimentum nisl non tempus efficitur. Vestibulum non lectus consectetur, ultricies est a, auctor massa. Aliquam sit amet mauris vitae felis bibendum posuere. Pellentesque eget posuere tellus. Vestibulum vestibulum ipsum ut eros vulputate, vitae mattis sapien sollicitudin. Integer fringilla, neque vitae viverra lobortis, felis felis faucibus turpis, at tincidunt diam elit id urna. Phasellus dignissim purus quis libero malesuada, et blandit lectus pharetra. Praesent et ante vel risus scelerisque porttitor.', 'deneme', '/web/images/b3.jpg', '2004-10-19 10:23:54+03', true, 2, 2);
INSERT INTO public."Blogs" ("BlogId", "BlogTitle", "BlogContent", "BlogThumbnailImage", "BlogImage", "BlogCreateDate", "BlogStatus", "CategoryID", "WriterID") VALUES (3, 'deneme', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur venenatis pretium tincidunt. Fusce condimentum nisl non tempus efficitur. Vestibulum non lectus consectetur, ultricies est a, auctor massa. Aliquam sit amet mauris vitae felis bibendum posuere. Pellentesque eget posuere tellus. Vestibulum vestibulum ipsum ut eros vulputate, vitae mattis sapien sollicitudin. Integer fringilla, neque vitae viverra lobortis, felis felis faucibus turpis, at tincidunt diam elit id urna. Phasellus dignissim purus quis libero malesuada, et blandit lectus pharetra. Praesent et ante vel risus scelerisque porttitor.', 'deneme', '/web/images/b4.jpg', '2004-10-19 10:23:54+03', true, 3, 3);


--
-- TOC entry 3620 (class 0 OID 0)
-- Dependencies: 223
-- Name: Blogs_BlogId_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public."Blogs_BlogId_seq"', 6, true);


-- Completed on 2023-03-14 17:12:35 +03

--
-- PostgreSQL database dump complete
--

