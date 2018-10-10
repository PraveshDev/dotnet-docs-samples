// Copyright(c) 2018 Google Inc.
//
// Licensed under the Apache License, Version 2.0 (the "License"); you may not
// use this file except in compliance with the License. You may obtain a copy of
// the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS, WITHOUT
// WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the
// License for the specific language governing permissions and limitations under
// the License.
//
// [START bigquery_create_dataset]
using Google.Cloud.BigQuery.V2;
using System;

public partial class BigQuerySample
{
    public BigQueryDataset CreateDataset()
    {
        BigQueryClient client = BigQueryClient.Create("your-project-id");
        return client.CreateDataset("your_dataset_id");
    }
}
// [END bigquery_create_dataset]
