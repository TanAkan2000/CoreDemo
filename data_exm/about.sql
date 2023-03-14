--
-- PostgreSQL database dump
--

-- Dumped from database version 15.1
-- Dumped by pg_dump version 15.1

-- Started on 2023-03-14 17:13:30 +03

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
-- TOC entry 3610 (class 0 OID 16550)
-- Dependencies: 216
-- Data for Name: Abouts; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public."Abouts" ("AboutID", "AboutDetails1", "AboutDetails2", "AboutImage1", "AboutImage2", "AboutMapLocation", "AboutStatus") VALUES (1, 'Blogların içeriği geleneksel internet içeriğinden farklılık gösterdiği için sadece bloglar için kurulmuş özel indeksleme mekanizmaları ve arama motorları bulunmaktadır. Technorati en başarılı blog teknolojilerinden biridir. Ayrıca Google Blog Search adında bir blog arama motoru işletmektedir. 2005 yılında Verisign tarafından satın alınan Weblogs.com, dünyanın en büyük blog ping servisi olarak tüm internet indeksleme mekanizmalarına veri sağlamaktadır.

İnternet ile ilgili ciddi bir araştırma kurumu olan Jupiter Research''ün 2005 yılında yaptığı bir araştırmasına göre, blog sitesi sahiplerinin yarısının yıllık geliri 60.000 doların üstünde; blog okuyanların %60''ı erkek ve blog okuma alışkanlığı olanların %73''ü 5 yıldan uzun süredir internet bağlantısına sahip. Blog okuyanların %28''i blog okumak için RSS kullanıyor. 2005 sonunda yapılan başka bir araştırmaya göre de internet kullanıcılarının %38''i blog kelimesinin anlamını bildiklerini, %27''si ise blog okuduklarını belirtmiştir. Blogosferin nabzını tutma misyonundaki Technorati''nin istatistiklerine göre, günde 50.000''den fazla yeni blog sitesi yaratılıyor.

Blogların kullanımı 1999 yılında Blogger''ın bu hizmeti vermeye başlaması ve kısa süre sonra bunu ücretsiz hale getirmesi ile yaygınlaşmıştır. 2003 yılı Şubat ayında Google, Blogger''ı satın aldı ve Google araç çubuğuna, ziyaret edilen sayfanın adresini doğrudan bloğa girmeyi sağlayan ''Blog This!'' tuşu yerleştirdi. İngilizce bilen çoğu kişi ilk defa bu düğme sayesinde bloglar ile tanışmıştır.

Blogger ile aynı zamanlarda kurulan LiveJournal, sadece belirli kişilerin okumasına izin verilebilen blog sayfaları sağlayarak popüler olmuş bir blog sitesidir. Hâlen en çok blog yaratılan sistemlerden biri olan LiveJournal, yazdıklarını herkesle paylaşmak istemeyen ve grup bağlarına önem veren kişiler tarafından tercih ediliyor.

', 'deneme', 'deneme', 'deneme', 'deneme', 'deneme');


--
-- TOC entry 3616 (class 0 OID 0)
-- Dependencies: 215
-- Name: Abouts_AboutID_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public."Abouts_AboutID_seq"', 1, false);


-- Completed on 2023-03-14 17:13:30 +03

--
-- PostgreSQL database dump complete
--

