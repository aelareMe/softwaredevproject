PGDMP                         y            postgres    9.6.21    9.6.21 '    x           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                       false            y           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                       false            z           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                       false            {           1262    12401    postgres    DATABASE     ?   CREATE DATABASE postgres WITH TEMPLATE = template0 ENCODING = 'UTF8' LC_COLLATE = 'English_Philippines.1252' LC_CTYPE = 'English_Philippines.1252';
    DROP DATABASE postgres;
             postgres    false            |           0    0    DATABASE postgres    COMMENT     N   COMMENT ON DATABASE postgres IS 'default administrative connection database';
                  postgres    false    2171                        2615    2200    public    SCHEMA        CREATE SCHEMA public;
    DROP SCHEMA public;
             postgres    false            }           0    0    SCHEMA public    COMMENT     6   COMMENT ON SCHEMA public IS 'standard public schema';
                  postgres    false    4                        3079    12387    plpgsql 	   EXTENSION     ?   CREATE EXTENSION IF NOT EXISTS plpgsql WITH SCHEMA pg_catalog;
    DROP EXTENSION plpgsql;
                  false            ~           0    0    EXTENSION plpgsql    COMMENT     @   COMMENT ON EXTENSION plpgsql IS 'PL/pgSQL procedural language';
                       false    2                        3079    16384 	   adminpack 	   EXTENSION     A   CREATE EXTENSION IF NOT EXISTS adminpack WITH SCHEMA pg_catalog;
    DROP EXTENSION adminpack;
                  false                       0    0    EXTENSION adminpack    COMMENT     M   COMMENT ON EXTENSION adminpack IS 'administrative functions for PostgreSQL';
                       false    1            ?            1259    16473    task_study_details    TABLE     ?   CREATE TABLE public.task_study_details (
    study_details_id smallint NOT NULL,
    study_id bigint,
    study_percent smallint,
    study_notes character varying(255)
);
 &   DROP TABLE public.task_study_details;
       public         postgres    false    4            ?            1259    16471 '   task_study_details_study_details_id_seq    SEQUENCE     ?   CREATE SEQUENCE public.task_study_details_study_details_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 >   DROP SEQUENCE public.task_study_details_study_details_id_seq;
       public       postgres    false    191    4            ?           0    0 '   task_study_details_study_details_id_seq    SEQUENCE OWNED BY     s   ALTER SEQUENCE public.task_study_details_study_details_id_seq OWNED BY public.task_study_details.study_details_id;
            public       postgres    false    190            ?            1259    16450    schedule_study    TABLE     h  CREATE TABLE public.schedule_study (
    study_details_id smallint DEFAULT nextval('public.task_study_details_study_details_id_seq'::regclass) NOT NULL,
    study_id bigint,
    study_percent smallint,
    study_notes character varying(255),
    statisfaction_percent character varying(255),
    time_start timestamp(0) without time zone,
    time_end date
);
 "   DROP TABLE public.schedule_study;
       public         postgres    false    190    4            ?            1259    16464 
   task_study    TABLE       CREATE TABLE public.task_study (
    study_id bigint NOT NULL,
    study_name character varying(255),
    study_decription character varying(255),
    study_count character varying(255),
    study_limit smallint,
    study_total_percentage smallint,
    user_id integer
);
    DROP TABLE public.task_study;
       public         postgres    false    4            ?            1259    16462    task_study_study_id_seq    SEQUENCE     ?   CREATE SEQUENCE public.task_study_study_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 .   DROP SEQUENCE public.task_study_study_id_seq;
       public       postgres    false    4    189            ?           0    0    task_study_study_id_seq    SEQUENCE OWNED BY     S   ALTER SEQUENCE public.task_study_study_id_seq OWNED BY public.task_study.study_id;
            public       postgres    false    188            ?            1259    16456    subject    TABLE     ?   CREATE TABLE public.subject (
    study_id bigint DEFAULT nextval('public.task_study_study_id_seq'::regclass) NOT NULL,
    study_name character varying(255),
    study_decription character varying(255),
    study_limit smallint,
    user_id integer
);
    DROP TABLE public.subject;
       public         postgres    false    188    4            ?            1259    16477 	   user_info    TABLE     ?   CREATE TABLE public.user_info (
    user_id bigint NOT NULL,
    user_name character varying(255) NOT NULL,
    user_password character varying(255) NOT NULL
);
    DROP TABLE public.user_info;
       public         postgres    false    4            ?            1259    16483    user_info_user_id_seq    SEQUENCE     ~   CREATE SEQUENCE public.user_info_user_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 ,   DROP SEQUENCE public.user_info_user_id_seq;
       public       postgres    false    4    192            ?           0    0    user_info_user_id_seq    SEQUENCE OWNED BY     O   ALTER SEQUENCE public.user_info_user_id_seq OWNED BY public.user_info.user_id;
            public       postgres    false    193            ?           2604    16506    task_study study_id    DEFAULT     z   ALTER TABLE ONLY public.task_study ALTER COLUMN study_id SET DEFAULT nextval('public.task_study_study_id_seq'::regclass);
 B   ALTER TABLE public.task_study ALTER COLUMN study_id DROP DEFAULT;
       public       postgres    false    188    189    189            ?           2604    16507 #   task_study_details study_details_id    DEFAULT     ?   ALTER TABLE ONLY public.task_study_details ALTER COLUMN study_details_id SET DEFAULT nextval('public.task_study_details_study_details_id_seq'::regclass);
 R   ALTER TABLE public.task_study_details ALTER COLUMN study_details_id DROP DEFAULT;
       public       postgres    false    191    190    191            ?           2604    16508    user_info user_id    DEFAULT     v   ALTER TABLE ONLY public.user_info ALTER COLUMN user_id SET DEFAULT nextval('public.user_info_user_id_seq'::regclass);
 @   ALTER TABLE public.user_info ALTER COLUMN user_id DROP DEFAULT;
       public       postgres    false    193    192            n          0    16450    schedule_study 
   TABLE DATA               ?   COPY public.schedule_study (study_details_id, study_id, study_percent, study_notes, statisfaction_percent, time_start, time_end) FROM stdin;
    public       postgres    false    186   ?+       o          0    16456    subject 
   TABLE DATA               _   COPY public.subject (study_id, study_name, study_decription, study_limit, user_id) FROM stdin;
    public       postgres    false    187   ?+       q          0    16464 
   task_study 
   TABLE DATA               ?   COPY public.task_study (study_id, study_name, study_decription, study_count, study_limit, study_total_percentage, user_id) FROM stdin;
    public       postgres    false    189   9,       s          0    16473    task_study_details 
   TABLE DATA               d   COPY public.task_study_details (study_details_id, study_id, study_percent, study_notes) FROM stdin;
    public       postgres    false    191   V,       ?           0    0 '   task_study_details_study_details_id_seq    SEQUENCE SET     V   SELECT pg_catalog.setval('public.task_study_details_study_details_id_seq', 1, false);
            public       postgres    false    190            ?           0    0    task_study_study_id_seq    SEQUENCE SET     F   SELECT pg_catalog.setval('public.task_study_study_id_seq', 1, false);
            public       postgres    false    188            t          0    16477 	   user_info 
   TABLE DATA               F   COPY public.user_info (user_id, user_name, user_password) FROM stdin;
    public       postgres    false    192   s,       ?           0    0    user_info_user_id_seq    SEQUENCE SET     C   SELECT pg_catalog.setval('public.user_info_user_id_seq', 4, true);
            public       postgres    false    193            ?           2606    16489 *   task_study_details task_study_details_pkey 
   CONSTRAINT     v   ALTER TABLE ONLY public.task_study_details
    ADD CONSTRAINT task_study_details_pkey PRIMARY KEY (study_details_id);
 T   ALTER TABLE ONLY public.task_study_details DROP CONSTRAINT task_study_details_pkey;
       public         postgres    false    191    191            ?           2606    16491    task_study task_study_pkey 
   CONSTRAINT     ^   ALTER TABLE ONLY public.task_study
    ADD CONSTRAINT task_study_pkey PRIMARY KEY (study_id);
 D   ALTER TABLE ONLY public.task_study DROP CONSTRAINT task_study_pkey;
       public         postgres    false    189    189            ?           2606    16493    user_info unq_username 
   CONSTRAINT     V   ALTER TABLE ONLY public.user_info
    ADD CONSTRAINT unq_username UNIQUE (user_name);
 @   ALTER TABLE ONLY public.user_info DROP CONSTRAINT unq_username;
       public         postgres    false    192    192            ?           2606    16495    user_info user_info_pkey 
   CONSTRAINT     [   ALTER TABLE ONLY public.user_info
    ADD CONSTRAINT user_info_pkey PRIMARY KEY (user_id);
 B   ALTER TABLE ONLY public.user_info DROP CONSTRAINT user_info_pkey;
       public         postgres    false    192    192            ?           2606    16496    task_study tuser_id    FK CONSTRAINT     ?   ALTER TABLE ONLY public.task_study
    ADD CONSTRAINT tuser_id FOREIGN KEY (user_id) REFERENCES public.user_info(user_id) ON UPDATE CASCADE ON DELETE CASCADE;
 =   ALTER TABLE ONLY public.task_study DROP CONSTRAINT tuser_id;
       public       postgres    false    2038    192    189            ?           2606    16501    subject tuser_id    FK CONSTRAINT     ?   ALTER TABLE ONLY public.subject
    ADD CONSTRAINT tuser_id FOREIGN KEY (user_id) REFERENCES public.user_info(user_id) ON UPDATE CASCADE ON DELETE CASCADE;
 :   ALTER TABLE ONLY public.subject DROP CONSTRAINT tuser_id;
       public       postgres    false    2038    187    192            n   2   x?3?4????L,NQFF??&??
FV&V??@a.sb??qqq ?v?      o   X   x?3?qqp560?t?H?-?460?4?2?I-.???
?p:??$????K??R?K?:???J?s????ˡ??hcl? ?b0?      q      x?????? ? ?      s      x?????? ? ?      t   H   x?3????????2?,I-.qI,I?\&p?D????˜?<-5?3-?<???ˌ? ???<?(??????? 8?V     