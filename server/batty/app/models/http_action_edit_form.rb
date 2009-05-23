
# HTTPアクション編集フォーム
class HttpActionEditForm < ActiveForm
  column :enable,      :type => :boolean
  column :http_method, :type => :text
  column :url,         :type => :text
  column :body,        :type => :text

  validates_presence_of :http_method
  validates_presence_of :url
  validates_length_of :url, :maximum => HttpAction::UrlMaximumLength, :allow_nil => true
  validates_length_of :body, :maximum => HttpAction::BodyMaximumLength, :allow_nil => true
  validates_inclusion_of :http_method, :in => HttpAction::HttpMethods, :allow_nil => true
  validates_format_of :url, :with => URI.regexp(["http"]), :allow_nil => true

  def self.http_methods_for_select(options = {})
    options = options.dup
    include_blank = (options.delete(:include_blank) == true)
    raise(ArgumentError) unless options.empty?

    return HttpAction.http_methods_for_select(
      :include_blank => include_blank,
      :blank_label   => "(選択してください)")
  end

  def to_http_action_hash
    return {
      :enable      => self.enable,
      :http_method => self.http_method,
      :url         => self.url,
      :body        => self.body,
    }
  end
end