/*
Navicat PGSQL Data Transfer

Source Server         : localhost_5432
Source Server Version : 90621
Source Host           : localhost:5432
Source Database       : postgres
Source Schema         : public

Target Server Type    : PGSQL
Target Server Version : 90621
File Encoding         : 65001

Date: 2021-04-15 22:46:17
*/


-- ----------------------------
-- Sequence structure for task_study_details_study_details_id_seq
-- ----------------------------
DROP SEQUENCE IF EXISTS "public"."task_study_details_study_details_id_seq";
CREATE SEQUENCE "public"."task_study_details_study_details_id_seq"
 INCREMENT 1
 MINVALUE 1
 MAXVALUE 9223372036854775807
 START 1
 CACHE 1;

-- ----------------------------
-- Sequence structure for task_study_study_id_seq
-- ----------------------------
DROP SEQUENCE IF EXISTS "public"."task_study_study_id_seq";
CREATE SEQUENCE "public"."task_study_study_id_seq"
 INCREMENT 1
 MINVALUE 1
 MAXVALUE 9223372036854775807
 START 1
 CACHE 1;

-- ----------------------------
-- Sequence structure for user_info_user_id_seq
-- ----------------------------
DROP SEQUENCE IF EXISTS "public"."user_info_user_id_seq";
CREATE SEQUENCE "public"."user_info_user_id_seq"
 INCREMENT 1
 MINVALUE 1
 MAXVALUE 9223372036854775807
 START 4
 CACHE 1;
SELECT setval('"public"."user_info_user_id_seq"', 4, true);

-- ----------------------------
-- Table structure for schedule_study
-- ----------------------------
DROP TABLE IF EXISTS "public"."schedule_study";
CREATE TABLE "public"."schedule_study" (
"study_details_id" int2 DEFAULT nextval('task_study_details_study_details_id_seq'::regclass) NOT NULL,
"study_id" int8,
"study_percent" int2,
"study_notes" varchar(255) COLLATE "default",
"statisfaction_percent" varchar(255) COLLATE "default",
"time_start" date,
"time_end" date
)
WITH (OIDS=FALSE)

;

-- ----------------------------
-- Table structure for subject
-- ----------------------------
DROP TABLE IF EXISTS "public"."subject";
CREATE TABLE "public"."subject" (
"study_id" int8 DEFAULT nextval('task_study_study_id_seq'::regclass) NOT NULL,
"study_name" varchar(255) COLLATE "default",
"study_decription" varchar(255) COLLATE "default",
"study_limit" int2,
"user_id" int4
)
WITH (OIDS=FALSE)

;

-- ----------------------------
-- Table structure for user_info
-- ----------------------------
DROP TABLE IF EXISTS "public"."user_info";
CREATE TABLE "public"."user_info" (
"user_id" int8 DEFAULT nextval('user_info_user_id_seq'::regclass) NOT NULL,
"user_name" varchar(255) COLLATE "default" NOT NULL,
"user_password" varchar(255) COLLATE "default" NOT NULL,
"name" varchar(255) COLLATE "default"
)
WITH (OIDS=FALSE)

;

-- ----------------------------
-- Alter Sequences Owned By 
-- ----------------------------
ALTER SEQUENCE "public"."task_study_details_study_details_id_seq" OWNED BY "schedule_study"."study_details_id";
ALTER SEQUENCE "public"."task_study_study_id_seq" OWNED BY "subject"."study_id";
ALTER SEQUENCE "public"."user_info_user_id_seq" OWNED BY "user_info"."user_id";

-- ----------------------------
-- Primary Key structure for table schedule_study
-- ----------------------------
ALTER TABLE "public"."schedule_study" ADD PRIMARY KEY ("study_details_id");

-- ----------------------------
-- Primary Key structure for table subject
-- ----------------------------
ALTER TABLE "public"."subject" ADD PRIMARY KEY ("study_id");

-- ----------------------------
-- Uniques structure for table user_info
-- ----------------------------
ALTER TABLE "public"."user_info" ADD UNIQUE ("user_name");

-- ----------------------------
-- Primary Key structure for table user_info
-- ----------------------------
ALTER TABLE "public"."user_info" ADD PRIMARY KEY ("user_id");

-- ----------------------------
-- Foreign Key structure for table "public"."subject"
-- ----------------------------
ALTER TABLE "public"."subject" ADD FOREIGN KEY ("user_id") REFERENCES "public"."user_info" ("user_id") ON DELETE CASCADE ON UPDATE CASCADE;
