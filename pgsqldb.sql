PGDMP     -    0                y            postgres    9.6.21    9.6.21 '    x           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                       false            y           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                       false            z           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                       false            {           1262    12401    postgres    DATABASE     �   CREATE DATABASE postgres WITH TEMPLATE = template0 ENCODING = 'UTF8' LC_COLLATE = 'English_Philippines.1252' LC_CTYPE = 'English_Philippines.1252';
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
                       false    1            �            1259    16433    schedule_study    TABLE       CREATE TABLE public.schedule_study (
    study_details_id smallint NOT NULL,
    study_id bigint,
    study_percent smallint,
    study_notes character varying(255),
    statisfaction_percent character varying(255),
    time_start timestamp(0) without time zone,
    time_end date
);
 "   DROP TABLE public.schedule_study;
       public         postgres    false    4            �            1259    16439    subject    TABLE     �   CREATE TABLE public.subject (
    study_id bigint NOT NULL,
    study_name character varying(255),
    study_decription character varying(255),
    study_limit smallint,
    user_id integer
);
    DROP TABLE public.subject;
       public         postgres    false    4            �            1259    16404    task_study_study_id_seq    SEQUENCE     �   CREATE SEQUENCE public.task_study_study_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 .   DROP SEQUENCE public.task_study_study_id_seq;
       public       postgres    false    193    4            �           0    0    task_study_study_id_seq    SEQUENCE OWNED BY     P   ALTER SEQUENCE public.task_study_study_id_seq OWNED BY public.subject.study_id;
            public       postgres    false    189            �            1259    16393 
   task_study    TABLE     M  CREATE TABLE public.task_study (
    study_id bigint DEFAULT nextval('public.task_study_study_id_seq'::regclass) NOT NULL,
    study_name character varying(255),
    study_decription character varying(255),
    study_count character varying(255),
    study_limit smallint,
    study_total_percentage smallint,
    user_id integer
);
    DROP TABLE public.task_study;
       public         postgres    false    189    4            �            1259    16402 '   task_study_details_study_details_id_seq    SEQUENCE     �   CREATE SEQUENCE public.task_study_details_study_details_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 >   DROP SEQUENCE public.task_study_details_study_details_id_seq;
       public       postgres    false    192    4            �           0    0 '   task_study_details_study_details_id_seq    SEQUENCE OWNED BY     o   ALTER SEQUENCE public.task_study_details_study_details_id_seq OWNED BY public.schedule_study.study_details_id;
            public       postgres    false    188            �            1259    16399    task_study_details    TABLE     �   CREATE TABLE public.task_study_details (
    study_details_id smallint DEFAULT nextval('public.task_study_details_study_details_id_seq'::regclass) NOT NULL,
    study_id bigint,
    study_percent smallint,
    study_notes character varying(255)
);
 &   DROP TABLE public.task_study_details;
       public         postgres    false    188    4            �            1259    16406 	   user_info    TABLE     �   CREATE TABLE public.user_info (
    user_id bigint NOT NULL,
    user_name character varying(255) NOT NULL,
    user_password character varying(255) NOT NULL
);
    DROP TABLE public.user_info;
       public         postgres    false    4            �            1259    16412    user_info_user_id_seq    SEQUENCE     ~   CREATE SEQUENCE public.user_info_user_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 ,   DROP SEQUENCE public.user_info_user_id_seq;
       public       postgres    false    190    4            �           0    0    user_info_user_id_seq    SEQUENCE OWNED BY     O   ALTER SEQUENCE public.user_info_user_id_seq OWNED BY public.user_info.user_id;
            public       postgres    false    191            �           2604    16453    schedule_study study_details_id    DEFAULT     �   ALTER TABLE ONLY public.schedule_study ALTER COLUMN study_details_id SET DEFAULT nextval('public.task_study_details_study_details_id_seq'::regclass);
 N   ALTER TABLE public.schedule_study ALTER COLUMN study_details_id DROP DEFAULT;
       public       postgres    false    188    192    192            �           2604    16454    subject study_id    DEFAULT     w   ALTER TABLE ONLY public.subject ALTER COLUMN study_id SET DEFAULT nextval('public.task_study_study_id_seq'::regclass);
 ?   ALTER TABLE public.subject ALTER COLUMN study_id DROP DEFAULT;
       public       postgres    false    193    189    193            �           2604    16455    user_info user_id    DEFAULT     v   ALTER TABLE ONLY public.user_info ALTER COLUMN user_id SET DEFAULT nextval('public.user_info_user_id_seq'::regclass);
 @   ALTER TABLE public.user_info ALTER COLUMN user_id DROP DEFAULT;
       public       postgres    false    191    190            t          0    16433    schedule_study 
   TABLE DATA               �   COPY public.schedule_study (study_details_id, study_id, study_percent, study_notes, statisfaction_percent, time_start, time_end) FROM stdin;
    public       postgres    false    192   q+       u          0    16439    subject 
   TABLE DATA               _   COPY public.subject (study_id, study_name, study_decription, study_limit, user_id) FROM stdin;
    public       postgres    false    193   �+       n          0    16393 
   task_study 
   TABLE DATA               �   COPY public.task_study (study_id, study_name, study_decription, study_count, study_limit, study_total_percentage, user_id) FROM stdin;
    public       postgres    false    186   ,       o          0    16399    task_study_details 
   TABLE DATA               d   COPY public.task_study_details (study_details_id, study_id, study_percent, study_notes) FROM stdin;
    public       postgres    false    187   8,       �           0    0 '   task_study_details_study_details_id_seq    SEQUENCE SET     U   SELECT pg_catalog.setval('public.task_study_details_study_details_id_seq', 7, true);
            public       postgres    false    188            �           0    0    task_study_study_id_seq    SEQUENCE SET     E   SELECT pg_catalog.setval('public.task_study_study_id_seq', 4, true);
            public       postgres    false    189            r          0    16406 	   user_info 
   TABLE DATA               F   COPY public.user_info (user_id, user_name, user_password) FROM stdin;
    public       postgres    false    190   U,       �           0    0    user_info_user_id_seq    SEQUENCE SET     C   SELECT pg_catalog.setval('public.user_info_user_id_seq', 8, true);
            public       postgres    false    191            �           2606    16418 *   task_study_details task_study_details_pkey 
   CONSTRAINT     v   ALTER TABLE ONLY public.task_study_details
    ADD CONSTRAINT task_study_details_pkey PRIMARY KEY (study_details_id);
 T   ALTER TABLE ONLY public.task_study_details DROP CONSTRAINT task_study_details_pkey;
       public         postgres    false    187    187            �           2606    16420    task_study task_study_pkey 
   CONSTRAINT     ^   ALTER TABLE ONLY public.task_study
    ADD CONSTRAINT task_study_pkey PRIMARY KEY (study_id);
 D   ALTER TABLE ONLY public.task_study DROP CONSTRAINT task_study_pkey;
       public         postgres    false    186    186            �           2606    16422    user_info unq_username 
   CONSTRAINT     V   ALTER TABLE ONLY public.user_info
    ADD CONSTRAINT unq_username UNIQUE (user_name);
 @   ALTER TABLE ONLY public.user_info DROP CONSTRAINT unq_username;
       public         postgres    false    190    190            �           2606    16424    user_info user_info_pkey 
   CONSTRAINT     [   ALTER TABLE ONLY public.user_info
    ADD CONSTRAINT user_info_pkey PRIMARY KEY (user_id);
 B   ALTER TABLE ONLY public.user_info DROP CONSTRAINT user_info_pkey;
       public         postgres    false    190    190            �           2606    16425    task_study tuser_id    FK CONSTRAINT     �   ALTER TABLE ONLY public.task_study
    ADD CONSTRAINT tuser_id FOREIGN KEY (user_id) REFERENCES public.user_info(user_id) ON UPDATE CASCADE ON DELETE CASCADE;
 =   ALTER TABLE ONLY public.task_study DROP CONSTRAINT tuser_id;
       public       postgres    false    2038    190    186            �           2606    16448    subject tuser_id    FK CONSTRAINT     �   ALTER TABLE ONLY public.subject
    ADD CONSTRAINT tuser_id FOREIGN KEY (user_id) REFERENCES public.user_info(user_id) ON UPDATE CASCADE ON DELETE CASCADE;
 :   ALTER TABLE ONLY public.subject DROP CONSTRAINT tuser_id;
       public       postgres    false    2038    193    190            t   2   x�3�4���L,NQFF��&��
FV&V��@a.sb��qqq �v�      u   X   x�3�qqp560�t�H�-�460�4�2�I-.���
�p:��$����K��R�K�:��J�s��ˡ��hcl� �b0�      n      x������ � �      o      x������ � �      r   H   x�3��������2�,I-.qI,I�\&p�D����˜�<-5�3-�<���ˌ� ���<�(������� 8�V     