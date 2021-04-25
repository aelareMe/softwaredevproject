PGDMP     %                    y            postgres    9.6.21    9.6.21     m           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                       false            n           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                       false            o           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                       false                        2615    2200    public    SCHEMA        CREATE SCHEMA public;
    DROP SCHEMA public;
             postgres    false            p           0    0    SCHEMA public    COMMENT     6   COMMENT ON SCHEMA public IS 'standard public schema';
                  postgres    false    4            �            1259    16970    schedule_study    TABLE       CREATE TABLE public.schedule_study (
    study_details_id smallint NOT NULL,
    study_id bigint,
    type bigint,
    study_percent smallint DEFAULT 0,
    study_description character varying(255),
    time_start timestamp without time zone,
    time_end timestamp without time zone
);
 "   DROP TABLE public.schedule_study;
       public         postgres    false    4            �            1259    16968 #   schedule_study_study_details_id_seq    SEQUENCE     �   CREATE SEQUENCE public.schedule_study_study_details_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 :   DROP SEQUENCE public.schedule_study_study_details_id_seq;
       public       postgres    false    191    4            q           0    0 #   schedule_study_study_details_id_seq    SEQUENCE OWNED BY     k   ALTER SEQUENCE public.schedule_study_study_details_id_seq OWNED BY public.schedule_study.study_details_id;
            public       postgres    false    190            �            1259    16954    subject    TABLE     �   CREATE TABLE public.subject (
    study_id smallint NOT NULL,
    study_name character varying(255),
    study_decription character varying(255),
    study_limit bigint,
    user_id bigint
);
    DROP TABLE public.subject;
       public         postgres    false    4            �            1259    16952    subject_study_id_seq    SEQUENCE     }   CREATE SEQUENCE public.subject_study_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 +   DROP SEQUENCE public.subject_study_id_seq;
       public       postgres    false    4    189            r           0    0    subject_study_id_seq    SEQUENCE OWNED BY     M   ALTER SEQUENCE public.subject_study_id_seq OWNED BY public.subject.study_id;
            public       postgres    false    188            �            1259    16939 	   user_info    TABLE     �   CREATE TABLE public.user_info (
    user_id smallint NOT NULL,
    user_name character varying(255) NOT NULL,
    user_password character varying(255) NOT NULL,
    name character varying(255) NOT NULL
);
    DROP TABLE public.user_info;
       public         postgres    false    4            �            1259    16937    user_info_user_id_seq    SEQUENCE     ~   CREATE SEQUENCE public.user_info_user_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 ,   DROP SEQUENCE public.user_info_user_id_seq;
       public       postgres    false    4    187            s           0    0    user_info_user_id_seq    SEQUENCE OWNED BY     O   ALTER SEQUENCE public.user_info_user_id_seq OWNED BY public.user_info.user_id;
            public       postgres    false    186            �           2604    16973    schedule_study study_details_id    DEFAULT     �   ALTER TABLE ONLY public.schedule_study ALTER COLUMN study_details_id SET DEFAULT nextval('public.schedule_study_study_details_id_seq'::regclass);
 N   ALTER TABLE public.schedule_study ALTER COLUMN study_details_id DROP DEFAULT;
       public       postgres    false    190    191    191            �           2604    16957    subject study_id    DEFAULT     t   ALTER TABLE ONLY public.subject ALTER COLUMN study_id SET DEFAULT nextval('public.subject_study_id_seq'::regclass);
 ?   ALTER TABLE public.subject ALTER COLUMN study_id DROP DEFAULT;
       public       postgres    false    188    189    189            �           2604    16942    user_info user_id    DEFAULT     v   ALTER TABLE ONLY public.user_info ALTER COLUMN user_id SET DEFAULT nextval('public.user_info_user_id_seq'::regclass);
 @   ALTER TABLE public.user_info ALTER COLUMN user_id DROP DEFAULT;
       public       postgres    false    186    187    187            j          0    16970    schedule_study 
   TABLE DATA               �   COPY public.schedule_study (study_details_id, study_id, type, study_percent, study_description, time_start, time_end) FROM stdin;
    public       postgres    false    191   �!       t           0    0 #   schedule_study_study_details_id_seq    SEQUENCE SET     Q   SELECT pg_catalog.setval('public.schedule_study_study_details_id_seq', 2, true);
            public       postgres    false    190            h          0    16954    subject 
   TABLE DATA               _   COPY public.subject (study_id, study_name, study_decription, study_limit, user_id) FROM stdin;
    public       postgres    false    189   1"       u           0    0    subject_study_id_seq    SEQUENCE SET     B   SELECT pg_catalog.setval('public.subject_study_id_seq', 2, true);
            public       postgres    false    188            f          0    16939 	   user_info 
   TABLE DATA               L   COPY public.user_info (user_id, user_name, user_password, name) FROM stdin;
    public       postgres    false    187   l"       v           0    0    user_info_user_id_seq    SEQUENCE SET     C   SELECT pg_catalog.setval('public.user_info_user_id_seq', 1, true);
            public       postgres    false    186            �           2606    16976 "   schedule_study schedule_study_pkey 
   CONSTRAINT     n   ALTER TABLE ONLY public.schedule_study
    ADD CONSTRAINT schedule_study_pkey PRIMARY KEY (study_details_id);
 L   ALTER TABLE ONLY public.schedule_study DROP CONSTRAINT schedule_study_pkey;
       public         postgres    false    191    191            �           2606    16962    subject subject_pkey 
   CONSTRAINT     X   ALTER TABLE ONLY public.subject
    ADD CONSTRAINT subject_pkey PRIMARY KEY (study_id);
 >   ALTER TABLE ONLY public.subject DROP CONSTRAINT subject_pkey;
       public         postgres    false    189    189            �           2606    16947    user_info user_info_pkey 
   CONSTRAINT     [   ALTER TABLE ONLY public.user_info
    ADD CONSTRAINT user_info_pkey PRIMARY KEY (user_id);
 B   ALTER TABLE ONLY public.user_info DROP CONSTRAINT user_info_pkey;
       public         postgres    false    187    187            �           2606    16949 !   user_info user_info_user_name_key 
   CONSTRAINT     a   ALTER TABLE ONLY public.user_info
    ADD CONSTRAINT user_info_user_name_key UNIQUE (user_name);
 K   ALTER TABLE ONLY public.user_info DROP CONSTRAINT user_info_user_name_key;
       public         postgres    false    187    187            �           2606    16951 %   user_info user_info_user_password_key 
   CONSTRAINT     i   ALTER TABLE ONLY public.user_info
    ADD CONSTRAINT user_info_user_password_key UNIQUE (user_password);
 O   ALTER TABLE ONLY public.user_info DROP CONSTRAINT user_info_user_password_key;
       public         postgres    false    187    187            �           2606    16977    schedule_study fkstudy_id    FK CONSTRAINT     �   ALTER TABLE ONLY public.schedule_study
    ADD CONSTRAINT fkstudy_id FOREIGN KEY (study_id) REFERENCES public.subject(study_id);
 C   ALTER TABLE ONLY public.schedule_study DROP CONSTRAINT fkstudy_id;
       public       postgres    false    189    2027    191            �           2606    16963    subject fkuser_id    FK CONSTRAINT     y   ALTER TABLE ONLY public.subject
    ADD CONSTRAINT fkuser_id FOREIGN KEY (user_id) REFERENCES public.user_info(user_id);
 ;   ALTER TABLE ONLY public.subject DROP CONSTRAINT fkuser_id;
       public       postgres    false    189    187    2021            j   M   x�3�4�4�44�I-.Q,ͬ�4202�50�52U04�2��2�����2�3���A S���������Hq� m�.      h   +   x�3�tp552�acNC.#N＼<NC#c ����qqq ���      f   -   x�3�NM�342�b�*��+8�&')�&e�s��qqq ��:     