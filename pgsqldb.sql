PGDMP         /                y            postgres    9.6.21    9.6.21 $    k           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                       false            l           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                       false            m           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                       false            n           1262    12401    postgres    DATABASE     �   CREATE DATABASE postgres WITH TEMPLATE = template0 ENCODING = 'UTF8' LC_COLLATE = 'English_United States.1252' LC_CTYPE = 'English_United States.1252';
    DROP DATABASE postgres;
             postgres    false            o           0    0    DATABASE postgres    COMMENT     N   COMMENT ON DATABASE postgres IS 'default administrative connection database';
                  postgres    false    2158                        2615    2200    public    SCHEMA        CREATE SCHEMA public;
    DROP SCHEMA public;
             postgres    false            p           0    0    SCHEMA public    COMMENT     6   COMMENT ON SCHEMA public IS 'standard public schema';
                  postgres    false    7            q           0    0    SCHEMA public    ACL     &   GRANT ALL ON SCHEMA public TO PUBLIC;
                  postgres    false    7                        3079    12387    plpgsql 	   EXTENSION     ?   CREATE EXTENSION IF NOT EXISTS plpgsql WITH SCHEMA pg_catalog;
    DROP EXTENSION plpgsql;
                  false            r           0    0    EXTENSION plpgsql    COMMENT     @   COMMENT ON EXTENSION plpgsql IS 'PL/pgSQL procedural language';
                       false    2                        3079    16384 	   adminpack 	   EXTENSION     A   CREATE EXTENSION IF NOT EXISTS adminpack WITH SCHEMA pg_catalog;
    DROP EXTENSION adminpack;
                  false            s           0    0    EXTENSION adminpack    COMMENT     M   COMMENT ON EXTENSION adminpack IS 'administrative functions for PostgreSQL';
                       false    1            �            1259    16481    schedule_study    TABLE       CREATE TABLE public.schedule_study (
    study_details_id smallint NOT NULL,
    study_id bigint,
    study_percent smallint,
    study_notes character varying(255),
    statisfaction_percent character varying(255),
    time_start timestamp(0) without time zone,
    time_end date
);
 "   DROP TABLE public.schedule_study;
       public         postgres    false    7            �            1259    16434    subject    TABLE     �   CREATE TABLE public.subject (
    study_id bigint NOT NULL,
    study_name character varying(255),
    study_decription character varying(255),
    study_limit smallint,
    user_id integer
);
    DROP TABLE public.subject;
       public         postgres    false    7            �            1259    16484 '   task_study_details_study_details_id_seq    SEQUENCE     �   CREATE SEQUENCE public.task_study_details_study_details_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 >   DROP SEQUENCE public.task_study_details_study_details_id_seq;
       public       postgres    false    190    7            t           0    0 '   task_study_details_study_details_id_seq    SEQUENCE OWNED BY     o   ALTER SEQUENCE public.task_study_details_study_details_id_seq OWNED BY public.schedule_study.study_details_id;
            public       postgres    false    191            �            1259    16432    task_study_study_id_seq    SEQUENCE     �   CREATE SEQUENCE public.task_study_study_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 .   DROP SEQUENCE public.task_study_study_id_seq;
       public       postgres    false    189    7            u           0    0    task_study_study_id_seq    SEQUENCE OWNED BY     P   ALTER SEQUENCE public.task_study_study_id_seq OWNED BY public.subject.study_id;
            public       postgres    false    188            �            1259    16421 	   user_info    TABLE     �   CREATE TABLE public.user_info (
    user_id bigint NOT NULL,
    user_name character varying(255) NOT NULL,
    user_password character varying(255) NOT NULL,
    name character varying(255)
);
    DROP TABLE public.user_info;
       public         postgres    false    7            �            1259    16419    user_info_user_id_seq    SEQUENCE     ~   CREATE SEQUENCE public.user_info_user_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 ,   DROP SEQUENCE public.user_info_user_id_seq;
       public       postgres    false    7    187            v           0    0    user_info_user_id_seq    SEQUENCE OWNED BY     O   ALTER SEQUENCE public.user_info_user_id_seq OWNED BY public.user_info.user_id;
            public       postgres    false    186            �           2604    16487    schedule_study study_details_id    DEFAULT     �   ALTER TABLE ONLY public.schedule_study ALTER COLUMN study_details_id SET DEFAULT nextval('public.task_study_details_study_details_id_seq'::regclass);
 N   ALTER TABLE public.schedule_study ALTER COLUMN study_details_id DROP DEFAULT;
       public       postgres    false    191    190            �           2604    16486    subject study_id    DEFAULT     w   ALTER TABLE ONLY public.subject ALTER COLUMN study_id SET DEFAULT nextval('public.task_study_study_id_seq'::regclass);
 ?   ALTER TABLE public.subject ALTER COLUMN study_id DROP DEFAULT;
       public       postgres    false    188    189    189            �           2604    16488    user_info user_id    DEFAULT     v   ALTER TABLE ONLY public.user_info ALTER COLUMN user_id SET DEFAULT nextval('public.user_info_user_id_seq'::regclass);
 @   ALTER TABLE public.user_info ALTER COLUMN user_id DROP DEFAULT;
       public       postgres    false    186    187    187            g          0    16481    schedule_study 
   TABLE DATA                     public       postgres    false    190   M%       f          0    16434    subject 
   TABLE DATA                     public       postgres    false    189   �%       w           0    0 '   task_study_details_study_details_id_seq    SEQUENCE SET     U   SELECT pg_catalog.setval('public.task_study_details_study_details_id_seq', 7, true);
            public       postgres    false    191            x           0    0    task_study_study_id_seq    SEQUENCE SET     E   SELECT pg_catalog.setval('public.task_study_study_id_seq', 4, true);
            public       postgres    false    188            d          0    16421 	   user_info 
   TABLE DATA                     public       postgres    false    187   �&       y           0    0    user_info_user_id_seq    SEQUENCE SET     C   SELECT pg_catalog.setval('public.user_info_user_id_seq', 8, true);
            public       postgres    false    186            �           2606    16490 &   schedule_study task_study_details_pkey 
   CONSTRAINT     r   ALTER TABLE ONLY public.schedule_study
    ADD CONSTRAINT task_study_details_pkey PRIMARY KEY (study_details_id);
 P   ALTER TABLE ONLY public.schedule_study DROP CONSTRAINT task_study_details_pkey;
       public         postgres    false    190    190            �           2606    16442    subject task_study_pkey 
   CONSTRAINT     [   ALTER TABLE ONLY public.subject
    ADD CONSTRAINT task_study_pkey PRIMARY KEY (study_id);
 A   ALTER TABLE ONLY public.subject DROP CONSTRAINT task_study_pkey;
       public         postgres    false    189    189            �           2606    16431    user_info unq_username 
   CONSTRAINT     V   ALTER TABLE ONLY public.user_info
    ADD CONSTRAINT unq_username UNIQUE (user_name);
 @   ALTER TABLE ONLY public.user_info DROP CONSTRAINT unq_username;
       public         postgres    false    187    187            �           2606    16429    user_info user_info_pkey 
   CONSTRAINT     [   ALTER TABLE ONLY public.user_info
    ADD CONSTRAINT user_info_pkey PRIMARY KEY (user_id);
 B   ALTER TABLE ONLY public.user_info DROP CONSTRAINT user_info_pkey;
       public         postgres    false    187    187            �           2606    16495    schedule_study subjectid    FK CONSTRAINT     �   ALTER TABLE ONLY public.schedule_study
    ADD CONSTRAINT subjectid FOREIGN KEY (study_id) REFERENCES public.subject(study_id) ON UPDATE CASCADE ON DELETE CASCADE;
 B   ALTER TABLE ONLY public.schedule_study DROP CONSTRAINT subjectid;
       public       postgres    false    2025    190    189            �           2606    16451    subject tuser_id    FK CONSTRAINT     �   ALTER TABLE ONLY public.subject
    ADD CONSTRAINT tuser_id FOREIGN KEY (user_id) REFERENCES public.user_info(user_id) ON UPDATE CASCADE ON DELETE CASCADE;
 :   ALTER TABLE ONLY public.subject DROP CONSTRAINT tuser_id;
       public       postgres    false    187    2023    189            g   �   x�E�A�@����wSa�u3;u� �AjW�v��`���C�>����73L^Vٵ���/0��ި�S�s���Y� �H����]k4�o��'��V��[@�q�Td�m�<�k9���v.�����@0(��`�K��?.�'ў��i����+Ó�yoQ�@�      f   �   x����
�0E���ٵ� �
.\�P�VL�K�c��)y���)�������s��`��!/x	�kzѮ�k�Z��u��.:sj�K��b�B˦RXΠ��n��JD!���4M֡�論Ƈ4I��}��\"�$��	_���[Ͱ�5N
����'�4X%����-���      d   �   x���v
Q���W((M��L�+-N-���K�WЀ0St�����T(� ���<�(�Ts�	uV�0�QPOL�I,J542Vr`
��R
Y�y���\�Ե�n���1�:$��4�b��`�m�j��851OJ��X�@��O��sjbqb�BPiRf>�r.. 9���     